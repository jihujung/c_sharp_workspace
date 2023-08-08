namespace Data_Ex1
{
    class DataType
    {
        static void Main(string[] args)
        {
            // 디폴트 리터럴 타입
            123    // int 리터럴
            12.3   // double 리터럴
            "A"    // string 리터럴
            'a'    // char 리터럴
            true   // bool 리터럴


            //예제

            // Bool
            bool b = true;

           // Numeric
           short sh = -32768;   
           int i = 2147483647;  
           long l = 1234L;      // L suffix
           float f = 123.45F;   // F suffix
           double d1 = 123.45; 
           double d2 = 123.45D; // D suffix
           decimal d = 123.45M; // M suffix

           // Char/String
           char c = 'A';
           string s = "Hello";


           // DateTime  2011-10-30 12:35
           DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);


           //최대값, 최소값 프로퍼티 사용
           int i = int.MaxValue;
           float f = float.MinValue;


          //NULL을 가질 수 있는 문자열(string) 타입의 변수 s 에 null 을 할당하는 예
          string s;
          s = null;

          // 정수(int)나 날짜(DateTime)은 Value Type으로 null을 가질 수 없는데, C# 2.0에서부터 이러한 타입들에 NULL을 가질 수 있게 하였는데, 이를 Nullable Type 이라 부른다.
          // Nullable 타입
          int? i = null;
          i = 101;
            
          bool? b = null;

          //int? 를 int로 할당
          Nullable<int> j = null;
          j = 10;
          int k = j.Value;


        }
    }
}