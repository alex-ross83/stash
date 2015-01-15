<Query Kind="Program" />

void Main()
{
	var input = new int[]{1,7,3,4};
	get_products_of_all_ints_except_at_index(input);
}

// Define other methods and classes here
void get_products_of_all_ints_except_at_index(int[] input)
{
	var list = new List<int>();
	for (int i = 0; i < input.Length; i++)
	{
		var forwardProducts = 1;
		var backwardProducts = 1;
		//calculate product of numbers after the current index
		for (int j = i + 1; j < input.Length; j++)
		{
			forwardProducts = forwardProducts * input[j];
		}
		//calculate product of numbers before current index
		for (int k = i - 1; k > 0; k--)
		{
			backwardProducts = backwardProducts * input[k];
		}
		list.Add(backwardProducts*forwardProducts);
	}
	list.ToArray().Dump();
}