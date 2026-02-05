namespace AgregaceAKompozice
{
    public class Student
{
    public string Jmeno { get; }
    public string Prijmeni { get; }
    public int Rocnik { get; }

    public Student(string jmeno, string prijmeni, int rocnik)
        {
            if(string.IsNullOrWhiteSpace(jmeno))
                throw new ArgumentNullException("Jméno nesmí být prázdné.", nameof(jmeno));
            if(string.IsNullOrWhiteSpace(prijmeni))
                throw new ArgumentNullException("Příjmení nesmí být prázdné.", nameof(prijmeni));
            if(rocnik <=0)
                throw new ArgumentNullException("Ročník musí být kladné číslo.", nameof(rocnik));
        
            Jmeno = jmeno.Trim();
            Prijmeni = prijmeni.Trim();
            Rocnik = rocnik;
        }

    public override string ToString() => $"{Prijmeni} {Jmeno} {Rocnik}. ročník";

}
}