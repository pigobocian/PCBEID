using PCBEID.PCBDataTypes;
using System;
using System.Reflection.Metadata;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DokFile : GenericFile
{

    readonly PCBMemo idkontrah;   // identyfikator kontrahenta(numer) (15)
    readonly PCBDate data;        // Data dokumentu
    readonly PCBMemo nazwadok;    // nazwa dokumentu(10)  opis dozwolonych wartośći w pkt 7.
    readonly PCBMemo nrdok;       // numer dokumentu(25)
    readonly PCBDate termin;      // termin płatności
    readonly PCBMemo platnosc;    // sposób płatności(35)
    readonly PCBFloat suma;       // Wartość brutto dokumentu - liczone zgodnie z definicją dokumentu
    readonly PCBInt ilepoz;       // ilość pozycji
    readonly PCBFloat gotowka;    // zapłata gotówkowa przyjęta na dokumencie
    readonly PCBDate dot_data;    // data dokumentu powiązanego(np KP do FA)
    readonly PCBMemo dot_nazwadok;// nazwa dokumentu powiązanego(10) (np KP do FA)
    readonly PCBMemo dot_nrdok;   // numer dokumentu powiązanego(25) (np KP do FA)
    readonly PCBBool anulowany;	 // czy dokument został anulowany
    readonly PCBMemo uwagi;       // (Memo) Uwagi do dokumentu
    readonly PCBMemo nrzlec;      // numer zlecenia(20)
    readonly PCBMemo cecha_1;     // Cecha 1 (35)
    readonly PCBMemo cecha_2;     // Cecha 2 (35)
    readonly PCBMemo cecha_3;     // Cecha 3 (35)
    readonly PCBMemo idkontrahodb;// identyfikator kontrahenta odbierającego dokument(numer) (15)
    readonly PCBDate dataobow;    // data obowiązywania zamówienia
    readonly PCBMemo cecha_4;     // Cecha 4 (35)
    readonly PCBMemo cecha_5;     // Cecha 5 (35)
    readonly PCBMemo idkontrahdost;   // identyfikator kontrahenta dostawcy - (numer) (15);
    readonly PCBMemo magazyn;         // numer magazynu
    readonly PCBBool wydrukowany;     // czy dokument był drukowany na zwykłej drukarce;
    readonly PCBMemo zafiskalizowany; // status fiskalnego dokumentu, gdy dokument nie fiskalny to status jest "0 - NIE PODLEGA" patrz pkt 7.;

    readonly IPCBGenericDataType[] fields;

    public DokFile()
	{
        SetFileName("dok.txt");

        fields = new IPCBGenericDataType[26];

        idkontrah = new PCBMemo(0); fields[0] = idkontrah;
        data = new PCBDate(1); fields[1] = data;
        nazwadok = new PCBMemo(2); fields[2] = nazwadok;
        nrdok = new PCBMemo(3); fields[3] = nrdok;
        termin = new PCBDate(4); fields[4] = termin;
        platnosc = new PCBMemo(5); fields[5] = platnosc;
        suma = new PCBFloat(6); fields[6] = suma;
        ilepoz = new PCBInt(7); fields[7] = ilepoz;
        gotowka = new PCBFloat(8); fields[8] = gotowka;
        dot_data = new PCBDate(9); fields[9] = dot_data;
        dot_nazwadok = new PCBMemo(10); fields[10] = dot_nazwadok;
        dot_nrdok = new PCBMemo(11); fields[11] = dot_nrdok;
        anulowany = new PCBBool(12); fields[12] = anulowany;
        uwagi = new PCBMemo(13); fields[13] = uwagi;
        nrzlec = new PCBMemo(14); fields[14] = nrzlec;
        cecha_1 = new PCBMemo(15); fields[15] = cecha_1;
        cecha_2 = new PCBMemo(16); fields[16] = cecha_2;
        cecha_3 = new PCBMemo(17); fields[17] = cecha_3;
        idkontrahodb = new PCBMemo(18); fields[18] = idkontrahodb;
        dataobow = new PCBDate(19); fields[19] = dataobow;
        cecha_4 = new PCBMemo(20); fields[20] = cecha_4;
        cecha_5 = new PCBMemo(21); fields[21] = cecha_5;
        idkontrahdost = new PCBMemo(22); fields[22] = idkontrahdost;
        magazyn = new PCBMemo(23); fields[23] = magazyn;
        wydrukowany = new PCBBool(24); fields[24] = wydrukowany;
        zafiskalizowany = new PCBMemo(25); fields[25] = zafiskalizowany;

    }

    void SetIdKontrah(string idKontrah) => idkontrah.SetValue(idKontrah);
    void SetData(string data) => this.data.SetValue(data);
    void SetNazwadok(string nazwaDok) => nazwadok.SetValue(nazwaDok);
    void SetNrdok(string nrDok) => nrdok.SetValue(nrDok);
    void SetTermin(string termin) => this.termin.SetValue(termin);
    void SetPlatnosc(string platnosc) => this.platnosc.SetValue(platnosc);
    void SetSuma(string suma) => this.suma.SetValue(suma);
    void SetIlepoz(string ilePoz) => this.ilepoz.SetValue(ilePoz);
    void SetGotowka(string gotowka) => this.gotowka.SetValue(gotowka);
    void SetDotData(string dotData) => this.dot_data.SetValue(dotData);
    void SetDotNazwadok(string dotNazwaDok) => this.dot_nazwadok.SetValue(dotNazwaDok);
    void SetDotNrdok(string dotNrDok) => this.dot_nrdok.SetValue(dotNrDok);
    void SetAnulowany(string anulowany) => this.anulowany.SetValue(anulowany);
    void SetUwagi(string uwagi) => this.uwagi.SetValue(uwagi);
    void SetNrzlec(string nrZlec) => this.nrzlec.SetValue(nrZlec);
    void SetCecha1(string cecha1) => this.cecha_1.SetValue(cecha1);
    void SetCecha2(string cecha2) => this.cecha_2.SetValue(cecha2);
    void SetCecha3(string cecha3) => this.cecha_3.SetValue(cecha3);
    void SetIdKontrahodb(string idKontrahOdb) => this.idkontrahodb.SetValue(idKontrahOdb);
    void SetDataobow(string dataObow) => this.dataobow.SetValue(dataObow);
    void SetCecha4(string cecha4) => this.cecha_4.SetValue(cecha4);
    void SetCecha5(string cecha5) => this.cecha_5.SetValue(cecha5);
    void SetIdKontrahdost(string idKontrahDost) => this.idkontrahdost.SetValue(idKontrahDost);
    void SetMagazyn(string magazyn) => this.magazyn.SetValue(magazyn);
    void SetWydrukowany(string wydrukowany) => this.wydrukowany.SetValue(wydrukowany);
    void SetZafiskalizowany(string zafiskalizowany) => this.zafiskalizowany.SetValue(zafiskalizowany);

    void CommitLine()
    {
        string line = "";
        for (int i = 0; i < 26; i++)
        {
            line += fields[i].GetValue() + '\t';
            fields[i].Clear();
        }
        line = line.TrimEnd('\t');

        AddLine(line);
    }

}

