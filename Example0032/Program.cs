Console.WriteLine("Введите число");
int Day;
Day = Convert.ToInt32(Console.ReadLine());
if (Day <=5){
    Console.WriteLine("Нет, это рабочий день");
}
else if (Day <=7){
    Console.WriteLine("Да, это выходной день");
}
Console.ReadLine();