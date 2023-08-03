using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;
using System.Text;

namespace ItalianPizza
{
    public class Pizza
    {
        Base @base;
        Sause sause;
        Cheese cheese;
        List<Addon> addons;

        public Pizza(IngredientsFactory factory)
        {
            @base = factory.CreateBase();
            sause = factory.CreateSause();
            cheese = factory.CreateCheese();
            addons = factory.CreateAddons();
        }

        public double CalculatePrice()
        {
            double totalPrice = 0;
            totalPrice += @base.Price;
            totalPrice += sause.Price;
            totalPrice += cheese.Price;
            foreach (Addon addon in addons)
            {
                totalPrice += addon.Price;  
            }
            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Base:\t{@base.Name}");
            sb.AppendLine($"Sause:\t{sause.Name}");
            sb.AppendLine($"Cheese:\t{cheese.Name}");
            sb.AppendLine($"Ingredients:\t");
            foreach (Addon addon in addons)
            {
                sb.AppendLine($"\t{addon.Name}");
            }
            return sb.ToString();
        }


    }

    //Cheeses
    public abstract class Cheese
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
    }
    public class Mozarella : Cheese
    {
        public override string Name { get; set; } = "Mozarella";
        public override int Price { get; set; } = 10;
    }
    public class Parmesan : Cheese
    {
        public override string Name { get; set; } = "Parmesan";
        public override int Price { get; set; } = 12;
    }
    public class Ricotta : Cheese
    {
        public override string Name { get; set; } = "Ricotta";
        public override int Price { get; set; } = 15;
    }


    //Bases
    public abstract class Base
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
    }
    public class Standart : Base
    {
        public override string Name { get; set; } = "Standart Base";
        public override int Price { get; set; } = 20;
    }
    public class XXL : Base
    {
        public override string Name { get; set; } = "XXL Base";
        public override int Price { get; set; } = 25;
    }


    //Sauses
    public abstract class Sause
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
    }
    public class Tomato : Sause
    {
        public override string Name { get; set; } = "Tomato Sause";
        public override int Price { get; set; } = 5;
    }
    public class Barbecue : Sause
    {
        public override string Name { get; set; } = "Barbecue Sause";
        public override int Price { get; set; } = 7;
    }

    //Addons
    public abstract class Addon
    {
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
    }
    public class Mushroom : Addon
    {
        public override string Name { get; set; } = "Mushroom";
        public override int Price { get; set; } = 5;
    }
    public class Seafood : Addon
    {
        public override string Name { get; set; } = "Seafood";
        public override int Price { get; set; } = 7;
    }
    public class Salami : Addon
    {
        public override string Name { get; set; } = "Salami";
        public override int Price { get; set; } = 9;
    }
    public class Papperoni : Addon
    {
        public override string Name { get; set; } = "Papperoni";
        public override int Price { get; set; } = 11;
    }



    //Factories
    public abstract class IngredientsFactory
    {
        public abstract string Name { get; set; }
        public abstract Base CreateBase();   
        public abstract Sause CreateSause();   
        public abstract Cheese CreateCheese();   
        public abstract List<Addon> CreateAddons();   
    }

    public class VenetoPizza : IngredientsFactory
    {
        public override string Name { get; set; } = "VenetoPizza";
        public override List<Addon> CreateAddons()
        {
            List<Addon> AddonsList = new List<Addon>();
            AddonsList.Add(new Mushroom());
            AddonsList.Add(new Papperoni());
            AddonsList.Add(new Salami());
            return AddonsList;
        }
        public override Base CreateBase()
        {
            return new Standart();
        }
        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }
        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }
    public class CampaniaPizza : IngredientsFactory
    {
        public override string Name { get; set; } = "CampaniaPizza";
        public override List<Addon> CreateAddons()
        {
            List<Addon> AddonsList = new List<Addon>();
            AddonsList.Add(new Seafood());
            AddonsList.Add(new Salami());
            return AddonsList;
        }
        public override Base CreateBase()
        {
            return new XXL();
        }
        public override Cheese CreateCheese()
        {
            return new Ricotta();
        }
        public override Sause CreateSause()
        {
            return new Barbecue();
        }
    }




}