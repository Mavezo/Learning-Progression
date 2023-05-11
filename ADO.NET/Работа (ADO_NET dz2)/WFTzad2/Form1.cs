using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;

namespace WFTzad2
{
    public partial class Form1 : Form
    {
        string strConn;
        DataTable dt;
        DbProviderFactory providerFactory;
        public string currentProvider { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        List<string> actualTypes = new List<string>();
        private void LoadData_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "System.Data.SqlClient")
            LoadWithCommand("Select Provider.Name as ProviderName, Item.Name as ItemName, ItemsType.Type as Type, Provider.[Count] as ItemsCount, Item.CostPrice, Provider.[Date] from Provider join Item on (Item.ID = Provider.IdItem) join ItemsType on (ItemsType.ID = Item.IdType)");
            else if (comboBox1.Text == "Npgsql")
                LoadWithCommand("Select \"Provider\".\"Name\" as \"ProviderName\", \"Item\".\"Name\" as \"ItemName\", \"ItemsType\".\"Type\" as \"Type\", \"Provider\".\"Count\" as \"ItemsCount\", \"Item\".\"CostPrice\", \"Provider\".\"Date\" from \"Provider\" join \"Item\" on (\"Item\".\"ID\" = \"Provider\".\"IdItem\") join \"ItemsType\" on (\"ItemsType\".\"ID\" = \"Item\".\"IdType\")\r\n");

        }
        private void LoadType_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "System.Data.SqlClient")
                LoadWithCommand("Select ItemsType.ID, ItemsType.Type as Type from ItemsType");
            else if (comboBox1.Text == "Npgsql")
                LoadWithCommand("Select \"ItemsType\".\"ID\", \"ItemsType\".\"Type\" as \"Type\" from \"ItemsType\"");
        }

        public async void LoadWithCommand(string sqlQuery)
        {
             dt = new DataTable();
            using (DbConnection connection = providerFactory.CreateConnection()) 
            {
                connection.ConnectionString = strConn;
                DbDataReader reader = null;
                DbCommand command = connection.CreateCommand();
                command.CommandText = sqlQuery;
                command.Connection = connection;
                try
                {
                    await connection.OpenAsync();
                    reader = await command.ExecuteReaderAsync();
                    dt.Columns.Clear();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dt.Columns.Add(reader.GetName(i));
                    }
                    actualTypes.Clear();
                    while (await reader.ReadAsync())
                    {
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetName(i) == "Type")
                            {
                                bool A = true;
                                foreach (var item in actualTypes)
                                {
                                    if (item == reader[i].ToString())
                                    {
                                        A = false;
                                        break;
                                    }
                                }
                                if (A)
                                    actualTypes.Add(reader[i].ToString());
                            }
                            row[i] = reader[i];
                        }
                        dt.Rows.Add(row);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Îøèáêà: {ex.Message}");
                }
                finally
                {
                    await connection.CloseAsync();
                    reader?.Close();
                    command?.Dispose();
                }

            }
            dataGridView1.DataSource = dt;

        }


        private void LoadItems_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "System.Data.SqlClient")
                LoadWithCommand("Select Item.[Name] as ItemName, ItemsType.Type as Type, Item.CostPrice as CostPrice from Item join ItemsType on (ItemsType.ID = Item.IdType)");
            else if (comboBox1.Text == "Npgsql")
                LoadWithCommand("Select \"Item\".\"Name\" as \"ItemName\", \"ItemsType\".\"Type\" as \"Type\", \"Item\".\"CostPrice\" as \"CostPrice\" from \"Item\" join \"ItemsType\" on (\"ItemsType\".\"ID\" = \"Item\".\"IdType\")");
        }

        public async void InsertWithCommand(string sqlQuery)
        {
                using (DbConnection conn = providerFactory.CreateConnection())
                {
                    conn.ConnectionString = strConn;
                    await conn.OpenAsync();
                    try
                    {
                        DbCommand command = conn.CreateCommand();
                        command.CommandText = sqlQuery;
                        MessageBox.Show($"{await command.ExecuteNonQueryAsync()} rows affected");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Îøèáêà: {ex.Message}");
                    }
                    finally
                    {
                        await conn.CloseAsync();
                    }



                }



            }
        


        private void NewType_Click(object sender, EventArgs e)
        {
            LoadData_Click(sender, e);
            AddType form2 = new AddType();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                if (comboBox1.Text == "System.Data.SqlClient")
                    InsertWithCommand($"Insert ItemsType values ('{form2.type.TypeName}')");
                else if (comboBox1.Text == "Npgsql")
                    InsertWithCommand($"insert into \"ItemsType\"(\"Type\") values ('{form2.type.TypeName}')");

            }
        }
        private void NewItem_Click(object sender, EventArgs e)
        {
            LoadType_Click(sender, e);

            AddItem form = new AddItem(actualTypes, this);
            currentProvider = comboBox1.Text;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Item item = form.item;
                if (comboBox1.Text == "System.Data.SqlClient")
                    InsertWithCommand($"Insert Item values ('{item.Name}', {item.IdType}, {item.Cost})");
                else if (comboBox1.Text == "Npgsql")
                    InsertWithCommand($"Insert \"Item\" (\"Name\", \"IdType\", \"CostPrice\") values ('{item.Name}', {item.IdType}, {item.Cost})");
            }
        }

        private void GetAllProvider_Click(object sender, EventArgs e)
        {
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("Npgsql", Npgsql.NpgsqlFactory.Instance);
            dt = DbProviderFactories.GetFactoryClasses();
            dataGridView1.DataSource = dt;
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "InvariantName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1) 
            {
                DataRowView selectedItem = comboBox1.SelectedItem as DataRowView;
                string providerName = selectedItem.Row.Field<string>("InvariantName");
                MessageBox.Show(providerName);
                ConnectionStringSettings settings = ConfigurationManager.
                    ConnectionStrings.OfType<ConnectionStringSettings>()
                    .LastOrDefault(t => t.ProviderName == providerName);
                if(settings != null)
                {
                    MessageBox.Show(settings.ConnectionString);
                    strConn = settings.ConnectionString;
                    providerFactory = DbProviderFactories.GetFactory(providerName);
                }
            }
        }
    }
}