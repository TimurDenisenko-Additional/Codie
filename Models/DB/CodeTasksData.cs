using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codie.Models.DB
{
    public class CodeTasksData
    {
        public static List<CodeTaskModel> codeData = new List<CodeTaskModel>
        {
        new CodeTaskModel
        {
            Id = 1,
            Task = @"Kirjuta meetod nimega IsPalindrome, mis kontrollib, kas antud string on palindroom.",
            Code = @"public bool IsPalindrome(string input) { int i = 0, j = input.Length - 1; while (i < j) { if (char.ToLower(input[i]) != char.ToLower(input[j])) return false; i++; j--; } return true; }",
            Tests = @"[""IsPalindrome(\""Level\"")"", ""IsPalindrome(\""Hello\"")"", ""IsPalindrome(\""Madam\"")""]"
        },
        new CodeTaskModel
        {
            Id = 2,
            Task = @"Kirjuta meetod nimega Factorial, mis arvutab antud mitte-negatiivse täisarvu faktoriaali.",
            Code = @"public int Factorial(int n) { if (n <= 1) return 1; else return n * Factorial(n - 1); }",
            Tests = @"[""Factorial(5)"", ""Factorial(0)"", ""Factorial(3)""]"
        },
        new CodeTaskModel
        {
            Id = 3,
            Task = @"Kirjuta meetod nimega Fibonacci, mis tagastab n-nda Fibonacci numbri.",
            Code = @"public int Fibonacci(int n) { if (n <= 1) return n; else return Fibonacci(n - 1) + Fibonacci(n - 2); }",
            Tests = @"[""Fibonacci(5)"", ""Fibonacci(0)"", ""Fibonacci(7)""]"
        },
        new CodeTaskModel
        {
            Id = 4,
            Task = @"Kirjuta meetod nimega ReverseString, mis pöörab antud stringi ümber.",
            Code = @"public string ReverseString(string s) { char[] arr = s.ToCharArray(); Array.Reverse(arr); return new string(arr); }",
            Tests = @"[""ReverseString(\""hello\"")"", ""ReverseString(\""\"")"", ""ReverseString(\""abcd\"")""]"
        },
        new CodeTaskModel
        {
            Id = 5,
            Task = @"Kirjuta meetod nimega IsPrime, mis kontrollib, kas antud number on algarv.",
            Code = @"public bool IsPrime(int num) { if (num <= 1) return false; for (int i = 2; i <= Math.Sqrt(num); i++) { if (num % i == 0) return false; } return true; }",
            Tests = @"[""IsPrime(7)"", ""IsPrime(10)"", ""IsPrime(13)""]"
        },
        new CodeTaskModel
        {
            Id = 6,
            Task = @"Kirjuta meetod nimega FindMax, mis tagastab täisarvude massiivist maksimaalse väärtuse.",
            Code = @"public int FindMax(int[] arr) { int max = arr[0]; foreach (int num in arr) { if (num > max) max = num; } return max; }",
            Tests = @"[""FindMax(new int[] {1, 3, 5, 7})"", ""FindMax(new int[] {-1, -3, -5})"", ""FindMax(new int[] {100})""]"
        },
        new CodeTaskModel
        {
            Id = 7,
            Task = @"Kirjuta meetod nimega SumArray, mis tagastab täisarvude massiivi elementide summa.",
            Code = @"public int SumArray(int[] arr) { int sum = 0; foreach (int num in arr) { sum += num; } return sum; }",
            Tests = @"[""SumArray(new int[] {1, 2, 3})"", ""SumArray(new int[] {0, 0, 0})"", ""SumArray(new int[] {-1, -2, -3})""]"
        },
        new CodeTaskModel
        {
            Id = 8,
            Task = @"Kirjuta meetod nimega CountVowels, mis loendab antud stringis täishäälikute arvu.",
            Code = @"public int CountVowels(string input) { int count = 0; string vowels = ""aeiouAEIOU""; foreach(char c in input) { if(vowels.IndexOf(c) >= 0) count++; } return count; }",
            Tests = @"[""CountVowels(\""hello\"")"", ""CountVowels(\""\"")"", ""CountVowels(\""xyz\"")""]"
        },
        new CodeTaskModel
        {
            Id = 9,
            Task = @"Kirjuta meetod nimega IsAnagram, mis kontrollib, kas kaks stringi on anagrammid.",
            Code = @"public bool IsAnagram(string s1, string s2) { if (s1.Length != s2.Length) return false; char[] arr1 = s1.ToLower().ToCharArray(); char[] arr2 = s2.ToLower().ToCharArray(); Array.Sort(arr1); Array.Sort(arr2); for (int i = 0; i < arr1.Length; i++) { if (arr1[i] != arr2[i]) return false; } return true; }",
            Tests = @"[""IsAnagram(\""listen\"", \""silent\"")"", ""IsAnagram(\""hello\"", \""world\"")"", ""IsAnagram(\""Triangle\"", \""Integral\"")""]"
        },
        new CodeTaskModel
        {
            Id = 10,
            Task = @"Kirjuta meetod nimega GCD, mis arvutab kahe täisarvu suurima ühisteguri.",
            Code = @"public int GCD(int a, int b) { while(b != 0) { int temp = b; b = a % b; a = temp; } return a; }",
            Tests = @"[""GCD(48, 18)"", ""GCD(7, 13)"", ""GCD(100, 10)""]"
        },
    };
    }
}