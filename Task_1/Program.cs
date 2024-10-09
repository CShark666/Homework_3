using Task_1;

//Task 1

int[] nums = { 1, 2, 3, 4, 5, };
var TestMyArray = new MyArray(nums);

TestMyArray.Show();
TestMyArray.Show("it's my array!!!");

//Task 2

Console.WriteLine();
Console.WriteLine("Max value: " + TestMyArray.Max());
Console.WriteLine("Min value: " + TestMyArray.Min());
Console.WriteLine("Average value: " + TestMyArray.Avg());

Console.WriteLine("Is there a number 4 in array: " + TestMyArray.Search(4));
Console.WriteLine("Is there a number 1 in array: " + TestMyArray.Search(1));
Console.WriteLine("Is there a number 6 in array: " + TestMyArray.Search(6));
Console.WriteLine();

//Task 3

TestMyArray.Show("before sorting: ");
Console.WriteLine();
TestMyArray.SortAsc();
TestMyArray.Show("after SortAsc: ");
Console.WriteLine();

TestMyArray.SortDesc();
TestMyArray.Show("after SortDesc:");
Console.WriteLine();

TestMyArray.SortByParam(true);
TestMyArray.Show("after SortByParam(true):");
Console.WriteLine();

TestMyArray.SortByParam(false);
TestMyArray.Show("after SortByParam(false):");
Console.WriteLine();