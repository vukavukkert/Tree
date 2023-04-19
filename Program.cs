using System.Collections.Generic;
using Tree;

Trees<string> tree = new Trees<string>();

tree.Add("A", 10); //root
tree.Add("B", 9); //root --> left
tree.Add("F", 2); //root --> left --> left
tree.Add("C", 11); // root --> right
tree.Add("D", 12); // root --> right --> right


var temp = tree.root;
while (temp != null)
{
    Console.WriteLine($"Point:{temp.Data}, Weight: {temp.Key}");
    temp = temp.Next_Right;
}
// 10, 11, 12 [done]

var temp1 = tree.root;
while (temp1 != null)
{
    Console.WriteLine($"Point:{temp1.Data}, Weight: {temp1.Key}");
    temp1 = temp1.Next_Left;
}
// 10, 9, 2 [done]

var temp2 = tree.Search(12);
Console.WriteLine($"Point:{temp2.Data}, Weight: {temp2.Key}");
// Point: D, Weight: 12


