using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Db;

internal interface IDb
{
	protected string PripojovaciRetezec { get; set; }

	internal void NastavitPripojovaciRetezec(string pripojovaciRetezec);

	internal bool ExistujeDatabaze();

	/// <summary>
	/// Vytvoří databázi
	/// </summary>
	/// <returns>Připojovací řetězec</returns>
	internal string VytvoritDatabazi();

	internal void VytvoritTabulky();

	/// <summary>
	/// Vrací <see cref="IEnumerable{Zamestnanec}"/> obsahující jména, příjmení, zkratky a ID
	/// </summary>
	/// <returns></returns>
	internal IEnumerable<Zamestnanec> ZiskatZamestnance();


	internal IEnumerable<Klic> ZiskatKlice();

	internal ZapujceneKliceZamestnancem ZiskatZapujceneKlice(Zamestnanec zamestnanec);

	internal ZapujcenyKlicZamestnancum ZiskatZapujceneKlice(Klic klic);



}
