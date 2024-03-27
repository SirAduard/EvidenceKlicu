CREATE TRIGGER trg_VytvoritTabulkuProKlic
ON [dbo].[Klice]
AFTER INSERT
AS
BEGIN
	DECLARE @NoveIdKlice INT
	SELECT @NoveIdKlice = Id FROM inserted;

	DECLARE @JmenoTabulky NVARCHAR(64);
	SET @JmenoTabulky = 'Klic_' + CAST(@NoveIdKlice AS NVARCHAR(64));

	DECLARE @SQL NVARCHAR(1024);
	SET @SQL = 'CREATE TABLE [dbo].' + QUOTENAME(@JmenoTabulky) + '
	(
		[ZapujcenoZamestnanciId] INT NOT NULL,
		[DatumZapujceni] DATETIME NOT NULL
	);
	';

	EXEC sp_executesql @SQL;
END;