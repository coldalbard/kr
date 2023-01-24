Console.WriteLine("Enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int size){
    string[] array = new string [size];
    Console.Write("Enter the array elements: ");
    for(int i = 0; i < size; i++){
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] arr = CreateArray(size);