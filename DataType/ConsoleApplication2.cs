using System;

namespace ConsoleApplication1
{
    class CSVar
    {
        //변수는 프로그램 중간에 값을 변경할 수 있지만,
        //상수(const로 선언)는 초기에 정한 값을 중간에 변경할 수 없다
        // 상수
        const int MAX_VALUE = 1024;

        // readonly 필드 
        readonly int Max;
        public CSVar() 
        {
           Max = 1;
        }
        
        //...
    }
}
