

int[] nums = [1,2,3,4]; int k = 5;

  Console.WriteLine(MaxOperations(nums,k));

int MaxOperations(int[] nums, int k)
{

      nums.Sort();

    int operations = 0;
    int left = 0; int right = nums.Length - 1;
    while (left < right)
    {
        int sum = nums[right] + nums[left];
        if (sum == k)
        {
            operations++;
            right--;
            left++;
        }

        if (sum > k)
        {
            right--;
        }

        if (sum < k)
        {
            left++;
        }
    }

    return operations;


}