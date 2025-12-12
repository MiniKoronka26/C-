using _012_Task_cigarettes;

Person person = new Person()
{
    Name = "John",
    Age = 13
};
Shop shop = new Shop()
{
    Name = "Silpo",
};

person.shopEventArgs += shop.Buy_or_no;

person.Buy();