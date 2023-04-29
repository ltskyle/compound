using compound;

namespace compound
{
    public class QuackCounter : IQuackable
    {
        IQuackable duck;
        static int numberOfQuacks;

        public QuackCounter(IQuackable duck){
            this.duck = duck;
        }
        public void Quack(){
            duck.Quack();
            numberOfQuacks++;
        }
        public static int GetNumberOfQuacks(){
            return numberOfQuacks;
        }
    }
}
