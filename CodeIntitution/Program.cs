// See https://aka.ms/new-console-template for more information
using CodeIntitution.Array;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

#region Array
RowTraversal rowTraversal = new RowTraversal();
ColumnTraversal colTraversal = new ColumnTraversal();
Pallindrome pallindrome = new Pallindrome();
FlipCharacters flipCharacters = new FlipCharacters();
ReverseSegment reverseSegment = new ReverseSegment();
VowelExchange vowelExchange = new VowelExchange();
ReverseWord reverseWord = new ReverseWord();
ReverseWordString reverseWordString = new ReverseWordString();
KRotation kRotation = new KRotation();
Container container = new Container();
#region Row-Major Traversal Problem

//Problem:

//Input: matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
//Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]
//Explanation: Above is the row-major traversal of the given matrix

int[,] matrix = new int[,]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
rowTraversal.RowMajorTraversal(matrix);

#endregion 

#region ColumnMajorTraversal
colTraversal.ColumnMajorTraversal(matrix);
#endregion


#region IsValidPallindrome Problem

string inputString = "a man nam a";
string inputString1 = "race car rac ecar";
string inputString2 = "This is codeintuition";
bool isPallindrome=pallindrome.PalindromeChecker(inputString);
bool isPallindrome1=pallindrome.PalindromeChecker(inputString1);
bool isPallindrome2=pallindrome.PalindromeChecker(inputString2);
Console.WriteLine($"The given word is pallindrome : {isPallindrome}");
Console.WriteLine($"The given word is pallindrome : {isPallindrome1}");
Console.WriteLine($"The given word is pallindrome : {isPallindrome2}");

bool isValid=pallindrome.IsValid(inputString1);
Console.WriteLine($"The given word is pallindrome :", isValid);
#endregion

#region FlipCharacters Problem
char[] input = new char[] { 'a', 'e', 'i', 'o', 'u' };

flipCharacters.FlipCharacterss(input);
#endregion

#region Reverse Segment
string s = "abcdefghij"; int k = 2;
var output=reverseSegment.ReverseSegments(s,k);
Console.WriteLine(output);
#endregion

#region VowelExchangeSegment
//string inputWord = "afegijoku";
string inputWord = "A man, a plan, a canal: Panama";

var outputWord=vowelExchange.VowelExchanges(inputWord);
Console.WriteLine(outputWord);
#endregion

#region Reverse word
string reverseWordOutput = reverseWord.ReverseWords("This is a string");
Console.WriteLine(reverseWordOutput);
#endregion

#region ReverseWordString
string reverseWordStrings = reverseWordString.ReverseWordOrder("This is a string");
Console.WriteLine(reverseWordStrings);
#endregion

#region KRotations
int[] arr = { 1, 2, 3, 4, 5 };
kRotation.KRotations(arr, 3);
#endregion

#region Container
container.LargestContainer();
#endregion
#endregion
