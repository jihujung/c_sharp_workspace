using System;

namespace MySystem1
{
   class Program
   {
      static void Main(string[] args)
      {         
        //C#에서 문자열(string)은 이중부호를 사용하여 표현되며, 단일 문자(char)는 단일부호를 사용하여 표현된다.
         // 문자열(string) 변수
         string s1 = "C#";
         string s2 = "Programming";

         // 문자(char) 변수 
         char c1 = 'A';
         char c2 = 'B';

         //C# 문자열은 Immutable 즉 한번 문자열이 설정되면, 다시 변경할 수 없다. 
         //(한번 그 값이 설정되면 다시 변경할 수 없는 타입을 Immutable Type이라 부르고, 반대로 값을 계속 변경할 수 있는 것을 Mutable Type이라 부른다) 
         // 문자열 결합
         string s3 = s1 + " " + s2;
         Console.WriteLine("String: {0}", s3);

         // 부분문자열 발췌
         string s3substring = s3.Substring(1, 5);
         Console.WriteLine("Substring: {0}", s3substring);
      }
   }
}