using CarRentalClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel.Resolution;
using System.ComponentModel;
using System.Text;


//develop a software information system for a car rental salon.
//The system stores information about the make and model of the car,
//the state registration number, the cost of renting a car per day, and
//the maximum allowable distance that can be traveled after renting a car. 

//After implementing the basic version of the information system,
//the salon owners wanted to add the possibility of adding a discount
//(for example, on holidays or weekends). When a discount is given,
//the cost of renting a car is reduced, and the maximum
//allowable distance is increased, by values determined by the terms of the promotion. 

//Think through the optimal architecture of the application taking into account possible changes in the requirements 


namespace Сar_Rental_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        BindingList<Car> cars;
        BindingList<Promotion> promotions;
        private async void Form1_Load(object sender, EventArgs e)
        {
            using (CarDbContext context = new CarDbContext())
            {

                cars = new BindingList<Car>(await context.Cars.ToListAsync());
                promotions = new BindingList<Promotion>(await context.Promotions.ToListAsync());
                cars_ListBox.DisplayMember = "StateRegistrationNumber";
                cars_ListBox.ValueMember = "Id";
                cars_ListBox.DataSource = cars;

            }


        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (CarDbContext context = new CarDbContext())
            {
                BindingList<Car> cars = new BindingList<Car>(await context.Cars.ToListAsync());
                if (int.TryParse(cars_ListBox.SelectedValue.ToString(), out int carId))
                {
                    Car? selectedCar = cars.Where(t => t.Id == carId).FirstOrDefault();
                    if (selectedCar != null)
                    {
                        DateTime currentDay = DateTime.Now;
                        CarConcreteDecoratorPromotion decoratorPromotion = new CarConcreteDecoratorPromotion(selectedCar);
                        foreach (var promotion in promotions)
                        {
                            if (promotion.StartDateOfPromotion.Ticks < currentDay.Ticks && promotion.EndDateOfPromotion.Ticks > currentDay.Ticks)
                            {
                                decoratorPromotion = new CarConcreteDecoratorPromotion(promotion, selectedCar);
                                decoratorPromotion.CalculatePromotion();
                                promotion_RichTextBox.Text = decoratorPromotion.currentPromotion.NameOfPromotion.ToString();

                                double maxDistanceBeforePromotion = selectedCar.MaxDistance;
                                double costOfRentingBeforePromotion = selectedCar.CostOfRentingPerDay;

                                maxDistance_RichTextBox.Text = $"{maxDistanceBeforePromotion}km" +
                                    $" + {decoratorPromotion.currentPromotion.IncreaseMaximumDistancePercent}%" +
                                    $" = ";

                                costOfRentingPerDay_RichTextBox.Text = $"{costOfRentingBeforePromotion}$" +
                                    $" - {decoratorPromotion.currentPromotion.DecreaseInRentalCostsPercent}%" +
                                    $" = ";


                            }
                            else
                            {
                                promotion_RichTextBox.Text = "None";
                            }
                        }

                        brand_RichTextBox.Text = decoratorPromotion.Brand;
                        model_RichTextBox.Text = decoratorPromotion.Model;
                        maxDistance_RichTextBox.Text += decoratorPromotion.MaxDistance.ToString() + " km";
                        costOfRentingPerDay_RichTextBox.Text += decoratorPromotion.CostOfRentingPerDay.ToString() + "$";





                    }
                    else MessageBox.Show("Wrong ID(selected car)");
                }
                else MessageBox.Show("Error");

            }

        }
    }
}