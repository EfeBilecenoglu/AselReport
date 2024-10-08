USE [master]
GO
/****** Object:  Database [Aselrapor]    Script Date: 16.6.2015 16:24:31 ******/
CREATE DATABASE [Aselrapor]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Aselrapor', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.VERISAYKO\MSSQL\DATA\Aselrapor.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Aselrapor_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.VERISAYKO\MSSQL\DATA\Aselrapor_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Aselrapor] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Aselrapor].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Aselrapor] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Aselrapor] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Aselrapor] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Aselrapor] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Aselrapor] SET ARITHABORT OFF 
GO
ALTER DATABASE [Aselrapor] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Aselrapor] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Aselrapor] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Aselrapor] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Aselrapor] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Aselrapor] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Aselrapor] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Aselrapor] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Aselrapor] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Aselrapor] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Aselrapor] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Aselrapor] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Aselrapor] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Aselrapor] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Aselrapor] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Aselrapor] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Aselrapor] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Aselrapor] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Aselrapor] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Aselrapor] SET  MULTI_USER 
GO
ALTER DATABASE [Aselrapor] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Aselrapor] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Aselrapor] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Aselrapor] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Aselrapor]
GO
/****** Object:  Table [dbo].[Islem]    Script Date: 16.6.2015 16:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Islem](
	[Islem_id] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [nvarchar](max) NULL,
	[rapor_id] [int] NULL,
 CONSTRAINT [PK_Islem] PRIMARY KEY CLUSTERED 
(
	[Islem_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rapor]    Script Date: 16.6.2015 16:24:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rapor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Yer] [nvarchar](50) NULL,
	[Gorevli_Personel] [nvarchar](50) NULL,
	[Tarih] [smalldatetime] NULL,
	[Gorev_Tipi] [nvarchar](15) NULL,
	[Sehir] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rapor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Islem] ON 

INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (1, N'İAT GÜNCELLEME', 1)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (2, N'İAT GÜNCELLEMESİ GENEL İŞLEM BASAMAKLARI ÖĞRENİLDİ', 2)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (3, N'JEMUS TELSİZ SİSTEMİ HAKKINDA EĞİTİME GİDİLDİ', 3)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (4, N'BOLU VE DÜZCE İLLERİNİN İAT Sİ GÜNCELLENDİ', 4)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (5, N'ÇANKIRI VE MANİSA İLLERİNİN İAT VİSCONFİG DOSYALARI DÜZELTİLDİ', 4)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (6, N'ÇANKIRI VE MANİSA İLLERİNİN TOPOLOJİLERİ ÇİZİLDİ', 4)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (7, N'AKSARAY İL JANDARMA MESAJLAŞMA ADRES DEFTERİ GÜNCELLENDİ', 5)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (8, N'AKSARAY İL JANDARMA MESAJLAŞMA YAZILIMI GÜNCELLENDİ', 5)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (9, N'KIRIKKALE İLİ İAT Sİ GÜNCELLENDİ', 6)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (10, N'NEVŞEHİR İL JANDARMA TABLETTE AÇILMAYAN HARİTALARIN YÜKLENMESİ', 7)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (11, N'NEVŞEHİR İL JANDARMA AÇILMAYAN KONSOL BİLGİSAYARININ YENİ ÇEVİRİCİ İLE AÇILMASI', 7)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (12, N'KIRKLARELİ İAT SERVERINA SP3 KURULDU', 8)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (13, N'KIRKLARELİ İAT Sİ GÜNCELLENDİ', 8)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (14, N'KAYSERİ İL JANDARMA SANTRAL VE SİSTEM SAATİNİN DÜZELTİLMESİ', 9)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (15, N'KONSOL BİLGİSAYARINDA AÇILMAYAN ATS TAZILIM İÇİN İMAGE ATMA', 10)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (16, N'KONSOL BİLGİSAYARINDA TELSİZ SESLİ MESAJLAŞMANIN ONARIMI', 10)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (17, N'BURDUR İLİ İAT Sİ GÜNCELLENDİ', 11)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (18, N'ISPARTA İLİ İAT Sİ GÜNCELLENDİ', 11)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (19, N'KÜTAHYA İLİ İAT Sİ GÜNCELLENDİ', 12)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (20, N'İSTANBUL,ADANA,AYDIN VE ANKARA NIN BÖLGE BİLGİSAYARLARINA BAT KURULUMU YAPILDI', 12)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (21, N'ISPARTA İLİ TOPOLOJİ HATASI DÜZELTİLDİ', 12)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (22, N'7 BÖLGE BİLGİSAYARINA BAT, SQL, VSI, SSI, ASELCOMP VE PDF CREATOR YÜKLENDİ', 13)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (23, N'İLLERE GÖNDERİLECEK BİLGİSAYARLARIN MAC ADRESİ NOT EDİLDİ', 13)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (24, N'ZONGULDAK İLİ İAT Sİ GÜNCELLENDİ ', 14)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (25, N'ANKARA BÖLGE BİLGİSAYARI İAT Sİ ORTAK KULLANICI İLE ÇALIŞTIRILDI', 14)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (26, N'7 BÖLGE BİLGİSAYARIN DAKİ TÜM EKSİK KURULUMLAR TAMAMLANDI', 15)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (27, N'7 BÖLGE BİLGİSAYARIDA ORTAK KULLANICI KULLANILARAK DENENDİ', 15)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (28, N'BOLU İLİ İAT Sİ ESKİSİ İLE ÇALIŞTIRILABALİR HALE GETİRİLDİ', 16)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (29, N'BOLU İLİ İAT Sİ İLE İLGİLİ ARIZA GİDERİLDİ', 17)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (30, N'KONYA İL JANDARMA MÜDÜRLÜĞÜNE TESLİMAT YAPILDI', 18)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (31, N'ESKİ İAT YENİSİ İLE BİRLİKTE ÇALIŞTIRILABİLİR HALE GETİRİLDİ', 18)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (32, N'UŞAK İAT PROGRAMINDAKİ UYARI DİNLEME CİHAZI HATASI GİDERİLDİ', 19)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (33, N'ANTALYA İAT SİNDEKİ EKSİK RADYOLİNK BAĞLANTISI YAPILDI', 19)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (34, N'JEMUS SİSTEM MİMARİSİ EĞİTİMİ', 20)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (35, N'SİSTEM BİLGİSAYARINDA Kİ BOZUK DİSKİN YEDEĞİ ALINMAYA BAŞLANDI', 21)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (36, N'SİSTEM BİLGİSAYARINDAKİ DİSKİN YEDEĞİ HARİCİ DİSKE ALINDI', 22)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (37, N'SİSTEM DİSKİ FORMATLANDI', 22)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (38, N'HARİCİ DİSKTEKİ DOSYALAR FORMATLANAN DİSKE GERİ YÜKLENDİ', 23)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (39, N'İL YÖNETİM SİSTEMLERİNİN GÜNCELLENMESİ', 24)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (40, N'MARMARA SAHİL GÜVENLİK İAT Sİ GÜNCELLEMESİ', 25)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (41, N'MARMARA BYM GÜNCELLEMESİ', 26)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (42, N'MARMARA BAT,BYM VE DİĞER SETUPLARIN KURULUMU', 27)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (43, N'ANKARA BÖLGE BİLGİSAYARINA BYM, AP25T47  VE AP25T49 KURULDU', 28)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (44, N'ANKARA BÖLGE BİLGİSAYARINDAKİ BY PROGRAMI HATASI DÜZELTİLDİ', 29)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (45, N'TELSİZ KISA MESAJ ARIZASI GİDERİLDİ', 30)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (46, N'TP4900 VE TP 4700 TELSİZLERİNİN SÜRÜMLERİ FP İLE ESKİ SÜRÜME ÇEKİLDİ', 31)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (47, N'YAZILIM GÜNCELLEME', 32)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (48, N'BİLGİSAYARLARA MAT KURULUMU', 33)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (49, N'KONSOL BİLGİSAYARLARININ RAMLERİ DEĞİŞTİ', 34)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (53, N'KONSOL HOPARLÖRÜ DEĞİŞTİRİLDİ', 35)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (54, N'ATC DEĞİŞTİ', 36)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (55, N'YEDEKLEME SUNUCUSU DEĞİŞTİRİLDİ', 37)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (56, N'TYPE BACKUP ARIZASI', 38)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (57, N'DÖNÜŞ (BALIKESİR-ANKARA)', 39)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (58, N'MERKEZ YÖNETİM SERVİSİ BİLGİSAYARI KURULUMU', 40)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (59, N'MAT KURULUMLARININ TAMAMLANMASI', 41)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (73, N'2 BİLGİSAYARA MAT KURULDU', 48)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (74, N'KOCAELİ İL HARITASI YENİ MAT BİLGİSAYARLARINA YÜKLENDİ', 48)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (75, N'ŞEHİR TOPOLOJİSİNDE BİR SÜRE SONRA OLUŞAN BAĞLANTI HATASI GİDERİLDİ', 48)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (76, N'KOCAELİ NDE ATC ARIZASI TESPİT EDİLDİ', 49)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (77, N'AKSARAY DA VİSCONFİG DÜZELTİLDİ', 49)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (78, N'AKSARAY VE MALATYA VSS BAĞLANTILARI DÜZELTİLDİ', 49)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (79, N'ZONGULDAK VE AKSARAYDA UYARI DİNLEME HATALARI ÇÖZÜLDÜ', 50)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (80, N'ÇANAKKALE VE İSTANBULDA 40 C ARIZALARI UYARI HALİNE GETİRİLDİ', 50)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (82, N'ANKARA, İSTANBUL,SAKARYA,KOCAELİ,MUĞLA DAKİ 30 C ARIZALARI UYARI HALİNE GETİRİLDİ', 50)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (83, N'TYPE BACKUP', 51)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (84, N'BÖLGE BİLGİSAYARLARINA BY, TELSİZ PROGRAMLARI VE FİLİGAN PROGRAMLARI YÜKLENDİ ', 52)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (85, N'ANKARA BÖLGE BİLGİSAYARINDAN EĞİTİM İÇİN SS LER ALINDI', 52)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (88, N'KONYA BAT INDAKİ BOŞ EKRAN HATASI GİDERİLDİ', 54)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (89, N'KİLİS,AKSARAY VE NEVŞEHİR DEKİ VGS HATALARI GİDERİLDİ', 54)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (90, N'KAHRAMANMARAŞ DAKİ İL YÖNETİM BAĞLANTI HATASI GİDERİLDİ', 54)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (91, N'OSMANİYE DE ARAÇ TAKİP VE VGS HATALARI GİDERİLDİ', 54)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (93, N'TELSİZ ARIZA TESPİTİ', 55)
INSERT [dbo].[Islem] ([Islem_id], [Aciklama], [rapor_id]) VALUES (95, N'deneme', 57)
SET IDENTITY_INSERT [dbo].[Islem] OFF
SET IDENTITY_INSERT [dbo].[Rapor] ON 

INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (1, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4660000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (2, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4670000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (3, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4680000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (4, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA46C0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (5, N'-----', N'Habip', CAST(0xA46C0000 AS SmallDateTime), N'Sehirdisi', N'AKSARAY')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (6, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA46D0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (7, N'-----', N'Habip', CAST(0xA46D0000 AS SmallDateTime), N'Sehirdisi', N'NEVŞEHİR')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (8, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA46E0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (9, N'-----', N'Habip', CAST(0xA46E0000 AS SmallDateTime), N'Sehirdisi', N'KAYSERİ')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (10, N'-----', N'Habip', CAST(0xA46F0000 AS SmallDateTime), N'Sehirdisi', N'NİĞDE')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (11, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA4730000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (12, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4740000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (13, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4750000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (14, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4760000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (15, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4790000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (16, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA47C0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (17, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA47D0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (18, N'-----', N'Ahmet Efe, Habip', CAST(0xA4800000 AS SmallDateTime), N'Sehirdisi', N'KONYA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (19, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4820000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (20, N'GÜVERCİNLİK', N'Habip', CAST(0xA4840000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (21, N'BEYTEPE', N'Ahmet Efe, Habip', CAST(0xA4880000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (22, N'BEYTEPE', N'Ahmet Efe', CAST(0xA4890000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (23, N'BEYTEPE', N'Ahmet Efe', CAST(0xA48A0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (24, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4900000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (25, N'SAHİL GÜV.KOM.', N'Ahmet Efe', CAST(0xA4910000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (26, N'SAHİL GÜV.KOM.', N'Ahmet Efe', CAST(0xA4990000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (27, N'SAHİL GÜV.KOM.', N'Ahmet Efe', CAST(0xA49F0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (28, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4A00000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (29, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA4A40000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (30, N'BEYTEPE', N'Ahmet Efe', CAST(0xA4A50000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (31, N'BEYTEPE', N'Ahmet Efe', CAST(0xA4A60000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (32, N'GÜVERCİNLİK', N'Habip', CAST(0xA4A70000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (33, N'BEŞTEPE', N'Ahmet Efe', CAST(0xA4A70000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (34, N'-----', N'Habip', CAST(0xA4980000 AS SmallDateTime), N'Sehirdisi', N'KAYSERİ')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (35, N'-----', N'Habip', CAST(0xA4990000 AS SmallDateTime), N'Sehirdisi', N'NİĞDE')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (36, N'-----', N'Habip', CAST(0xA4A30000 AS SmallDateTime), N'Sehirdisi', N'ISPARTA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (37, N'-----', N'Habip', CAST(0xA4A40000 AS SmallDateTime), N'Sehirdisi', N'ISPARTA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (38, N'-----', N'Habip', CAST(0xA4A50000 AS SmallDateTime), N'Sehirdisi', N'BALIKESİR')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (39, N'-----', N'Habip', CAST(0xA4A60000 AS SmallDateTime), N'Sehirdisi', N'BALIKESİR')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (40, N'GÜVERCİNLİK', N'Habip', CAST(0xA4AA0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (41, N'BEŞTEPE', N'Ahmet Efe', CAST(0xA4AA0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (48, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA4AB0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (49, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA4AC0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (50, N'GÜVERCİNLİK', N'Ahmet Efe', CAST(0xA4AE0000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (51, N'-----', N'Habip', CAST(0xA4AB0000 AS SmallDateTime), N'Sehirdisi', N'DÜZCE')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (52, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4B30000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (54, N'GÜVERCİNLİK', N'Ahmet Efe, Habip', CAST(0xA4B40000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (55, N'İL JANDARMA KMT.', N'Ahmet Efe, Habip', CAST(0xA4B50000 AS SmallDateTime), N'Sehirici', N'ANKARA')
INSERT [dbo].[Rapor] ([id], [Yer], [Gorevli_Personel], [Tarih], [Gorev_Tipi], [Sehir]) VALUES (57, N'BEŞTEPE', N'Ahmet Efe', CAST(0xA4B90000 AS SmallDateTime), N'Sehirici', N'ANKARA')
SET IDENTITY_INSERT [dbo].[Rapor] OFF
ALTER TABLE [dbo].[Islem]  WITH CHECK ADD  CONSTRAINT [FK_Islem_Rapor] FOREIGN KEY([rapor_id])
REFERENCES [dbo].[Rapor] ([id])
GO
ALTER TABLE [dbo].[Islem] CHECK CONSTRAINT [FK_Islem_Rapor]
GO
USE [master]
GO
ALTER DATABASE [Aselrapor] SET  READ_WRITE 
GO
