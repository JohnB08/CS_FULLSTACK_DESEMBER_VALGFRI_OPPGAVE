using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;
/* EKSEMPEL PÅ EN DICEROLLER ASSIGNMENT */

namespace C_ASSIGNMENT_BUILDER.Assignment
{
    public class DiceRollerTest : AssignmentBase
    {
        /// <summary>
        /// En diceroller Interface som dere kan fylle ut og endre. 
        /// Husk at en interface er en "kontrakt" at din class inneholder
        /// metoder med samme parameter og return values som interfacen. 
        /// En interface sier ingenting om properties i en Class. Men er
        /// en måte å "interface" med metodene i classen uten å tilgjengeliggjøre properties til en class. 
        /// 
        /// !!Det er fullt lov å endre denne interfacen, hvis dere føler det er nødvendig.
        /// </summary>
        public interface IDiceRoller
        {
            int Roll(int low, int high);
            double Roll(double low, double high);
        }

        //Fyll ut DiceRoller classen med din egen implementasjon av en diceroller class, som skal kunne levere tilfeldige tall, av forskjellige datatyper.
        //Husk at man må implementere alle methods i interfacen over, og 
        //Alle assignments må kunne fullføres. 

        public class DiceRoller : IDiceRoller
        {
            public int Roll(int low, int high)
            {
                throw new NotImplementedException();
            }

            public double Roll(double low, double high)
            {
                throw new NotImplementedException();
            }
        }

        //Initialiser din utgave av dicerolleren under, husk å legg til parametere hvis din utgave av en diceroller trenger det.
        //Tenk på om den burde være public eller private. Public hvis den skal være tilgjengelig utenfor classen, private hvis den er låst til denne classen.
        DiceRoller diceRoller = new();

        //I første assignent skal metoden returnere et tall mellom 1 og 6, man skal kunne trille en seks sidet terning.
        [Assignment(1)]
        public void TestRoll()
        {
            Assert.IsType<int>(diceRoller.Roll(1, 7));
            Assert.InRange<int>(diceRoller.Roll(1, 7), 1, 6);
        }

        //I andre assignment skal man kunne trille en terning med et vilkårlig antall sider.
        [Assignment(2)]
        public void TestRollWithInput()
        {
            //Her skal Roll metoden vår kunne rulle mellom vilkårlige tall.
            //Man skal skifte ut FILL_ME_IN med hvilket som helst int.
            //Hvordan vil du håndtere hvis lower er større enn higher?
            int lower = FILL_ME_IN;
            int higher = FILL_ME_IN;
            Assert.IsType<int>(diceRoller.Roll(lower, higher));
            Assert.InRange<int>(diceRoller.Roll(lower, higher), lower, higher);
        }


        //Her skal vi returnere et tilfeldig double mellom 0 og 1.
        [Assignment(3)]
        public void TestRandomDouble()
        {
            //Skift ut fill me inn med en metode i diceroller som leverer en tilfeldig Double
            //mellom 0 og 1.
            Assert.IsType<double>(diceRoller.Roll((double)0, (double)1));
            Assert.InRange<double>(diceRoller.Roll((double)0, (double)1), 0, 1);
        }

        //Her skal man få tilbake et tilfeldig double mellom verdien av to vilkårlige doubles.
        [Assignment(4)]
        public void TestRandomDoubleWithInput()
        {
            //Skift ut FILL_ME_IN med en metode i diceroller som leverer en tilfeldig double i en range.
            //Man skal skunne skifte ut FILL_ME_IN med hvilket som helst tall og metoden skal fungere.
            //Hvordan vil du håndtere tilfeller hvor lower er større enn higher?
            double lower = FILL_ME_IN;
            double higher = FILL_ME_IN;
            Assert.IsType<double>(diceRoller.Roll(lower, higher));
            Assert.InRange<double>(diceRoller.Roll(lower, higher), lower, higher);
        }
    }
}