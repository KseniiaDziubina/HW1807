Console.WriteLine("Введите число");
int Day;
Day = Convert.ToInt32(Console.ReadLine());
if (Day <=5) {
    Console.WriteLine("Рабочий день");
}
else if (Day <=7) {
    Console.WriteLine("Выходной день");
}
Console.ReadLine();