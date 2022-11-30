//Given two integers a and b (a <= b) as range, write a method that returns multiplication of numbers from given range.


namespace Program{
    class NumberMultiplicationTask{
        public static void Main(string [] args){
            Console.Clear();
            static long NumbersMultiplication(int num1 , int num2){
                
                 return  num1 > num2 ? 1 : num1 * NumbersMultiplication(num1+1, num2);
            }
            Console.WriteLine(NumbersMultiplication(5, 7));  //→ 210
            Console.WriteLine(NumbersMultiplication(50, 50)); // → 50
        }
    }
}