
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;
namespace C_ASSIGNMENT_BUILDER.Assignment;
public class ReadingData() : AssignmentBase
{

    private readonly DataContext? _context = null;
    /// <summary>
    /// Første assignment er å lese og lage en readonly Context som resten av metodene bruker. 
    /// </summary>
    [Assignment(1)]
    public override void Setup()
    {

        //Initialiser en context her, som leser youtube_subscription_data fra Datasets/youtube_subscription_data.csv
        //Lagre den nye contexten man setter opp her som _context;
        //Som med json, må man også her lage en modell av datasettet, man kan bruke headerlinjen (første linje) i filen som hint til hva navn og data man har. 
        //Hva datatype bør man bruke for å representere subscriber tallet?
        //_context skal ikke være null etter Setup() metoden er ferdig.
        Assert.NotNull(_context);
    }
    //Fyll inn classen under som en map av et set med data fra csv filen.
    //Husk å tenke på gode beskrivende navn. 
    public class SubscriberData : FillMeIn
    {

    }
    //Fyll inn classen under som en måte å holde hele representasjonen av datasettet i memory, samt alle metodene vi trenger for å manipulere og gjøre søk på datasettet.
    //Her bør man også legge inn en metode som konstruerer en ny instans av DataContext, som også leser csv filen inn i memory. 
    //Dette kan man gjøre på flere måter. 
    //Den letteste er å lese filen inn som text. Så lenge man husker at den første linjen i en csv fil alltid er en header med tabellnavn,
    //er resten av linjene kommaseparerte verdier som samkjører med tabellnavnet i header filen.
    //Eksempel:
    //I første linje, ser vi at den tredje kommaseparerte verdien er Subscriber (millions),
    //da er det trygt å annta at den tredje verdien i hver linje er et tall som representerer antall subscribers.
    //Her er det også en interface med et sett med funksjoner dere skal fylle ut innmaten til.
    //!! DET ER FULLT LOV Å ENDRE INTERFACEN HVIS MAN FØLER MAN TRENGER. 
    public interface IDataContext
    {
        /// <summary>
        /// Denne metoden skal inneholder en Linq for å gjøre en GroupBy på en liste av SubscriberData
        /// Siden disse skal være implementert i DataContext, kan disse referere til Subscribers.
        /// Her skal man kunne ta inn en lambda funksjon som parameter, selector. og returnere en GroupBy på SubscriberData
        /// basert på Selector. Husk her også at man returnerer dictionariet. Så her kan det være lurt å tenke på
        /// hvilken metode man bruker for å kolapse spørringen. 
        ///             Eksempel på bruk: 
        ///             _context.GroupByProperty(s=>s.ReleaseDate)
        /// </summary>
        /// <typeparam name="T">En generisk type som hentes fra input. Det tillater oss til å gi metoden typen til Selector når vi bruker metoden.</typeparam>
        /// <param name="Selector">Representerer en Lambda funksjon som skal returnere et parameter som kan brukes i en GroupBy</param>
        /// <returns></returns>
        public IDictionary<string, List<SubscriberData>> GroupByProperty<T>(Func<SubscriberData, T> selector);

        /// <summary>
        /// Denne metoden representerer en metode for å filtrere data i datasettet, gitt en predicate som returnerer true or false. 
        /// Her kan man bruke predicaten i en Where method mot Subscriberdata listen vår.
        /// Husk return valuen her også, så velg rett metode for å kolapse LinQ spørringen.
        /// 
        ///         Eksempel på bruk:
        ///         _context.FilterData(s=>s.ChannelName.StartsWith("B"))
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<SubscriberData> FilterData(Func<SubscriberData, bool> predicate);

        /// <summary>
        /// Denne metoden lar oss sortere datasettet vårt basert på et parameter. 
        ///         Eksempel på bruk:
        ///         _context.SortData(s=>s.ReleaseDate)
        /// Så her må man returnere en OrderBy på vårt datasett.
        /// Husk å se på return valuen til FilterData for å bestemme hva metode man bruker for å kollapse queryen.
        /// Kan det være lurt å endre parameteret her, for å tillate å skifte mellom OrderBy og OrderByDescending?
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public List<SubscriberData> SortData<TKey>(Func<SubscriberData, TKey> keySelector);
    }
    public class DataContext : IDataContext
    {
        public List<SubscriberData> Subscribers { get; set; } = [];

        public List<SubscriberData> FilterData(Func<SubscriberData, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, List<SubscriberData>> GroupByProperty<T>(Func<SubscriberData, T> selector)
        {
            throw new NotImplementedException();
        }

        public List<SubscriberData> SortData<TKey>(Func<SubscriberData, TKey> keySelector)
        {
            throw new NotImplementedException();
        }
        //Her kan det også være lurt å lage sin egen konstructor som kan lese og lagre SubscriberData.csv filen on boot. 
    }
    [Assignment(2)]
    public void TestGrouping()
    {
        //Bytt ut placeholder i GroupByProperty metoden vår for å kunne gruppere datasettet vårt rundt en spesifikk property. 
        var groupedBy = _context.GroupByProperty(FILL_ME_IN);
        Assert.True(groupedBy.ContainsKey(FILL_ME_IN));
    }
    [Assignment(3)]
    public void TestFiltering()
    {
        //Bytt ut placeholder i FilterData for å filtrere datasettet. 
        var filteredBy = _context.FilterData(FILL_ME_IN);
        Assert.True(filteredBy.Any());
    }
    [Assignment(4)]
    public void TestSorting()
    {
        //Skift ut placeholders med en property for å sortere datasettet vårt.
        //Hvordan vil du håndtere om man vil ha ascending eller descending sorting?
        var sortedBy = _context.SortData(FILL_ME_IN);
        Assert.True(sortedBy.First().FILL_ME_IN > sortedBy.Last().FILL_ME_IN);
    }
}