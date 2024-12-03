using Stack;

bool polindrome = true;
string num = Console.ReadLine();
int maxSize = num.Length;
StackImpl theStack = new StackImpl(maxSize);
for (int i = 0; i < maxSize; i++)
{
    theStack.push(num[i]);
}
    
if (maxSize % 2 == 0)
{
    StackImpl newStack = new StackImpl(maxSize / 2);
    while (!newStack.isFull())
    {
        newStack.push(theStack.pop());
    }
    for (int i = 0; i < maxSize / 2; i++)
    {
        if (newStack.pop() == theStack.pop()) ;
        else { polindrome = false; }
    }

}
else
{
    
    StackImpl newStack = new StackImpl((maxSize - 1) / 2);
    while (!newStack.isFull())
    {
        newStack.push(theStack.pop());
    }
    theStack.pop();
    for (int i = 0; i < (maxSize - 1) / 2; i++)
    {
     
        if (newStack.pop() == theStack.pop()) ;
        else { polindrome = false; }
    }
}


    if (polindrome) { Console.WriteLine("Строка является полиндромом"); }
else { Console.WriteLine("Строка не является полиндромом"); }
