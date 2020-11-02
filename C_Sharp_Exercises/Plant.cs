namespace arrays
{
    public class Plant
    {
        //with the contructor it is just a different way of writing
        //the instance variables. you can write them in the contructor to create
        //or construct the variable and it makes it easier to create new objects
        public Plant(string speciesName, string plantColor, int amountWateredMonthly){
            speciesName = speciesName;
            plantColor = plantColor;
            amountWateredMonthly = amountWateredMonthly;
        }
        public string name;
        public int age;
        public bool indoor;
        public int price;
        public decimal discount;
        public decimal tax;
        public decimal total;

        public string getBasicInfo(){
            return $"Hello new plant owner! You have purchased a {name} and it is a {age} y/o plant. It is {indoor} that it lives in your home. Take care of it!";
        }

        public string getPrice(){
            return $"Your {name} will cost {total = price * discount * tax}";
        }
    }
}
