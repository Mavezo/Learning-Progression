using ItalianPizza;

VenetoPizza veneto = new VenetoPizza();

Pizza pizza = new Pizza(veneto);

Console.WriteLine(pizza.ToString());
Console.WriteLine();
Console.WriteLine(pizza.CalculatePrice());


