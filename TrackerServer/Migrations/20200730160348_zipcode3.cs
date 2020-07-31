using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackerServer.Migrations
{
    public partial class zipcode3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstSigns",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 986, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 978, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CoronaTest",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 983, DateTimeKind.Local).AddTicks(3109),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 974, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.InsertData(
                table: "ZipCode",
                columns: new[] { "Id", "City", "Code" },
                values: new object[,]
                {
                    { 1, "'S Gravenwezel SCHILDE", "2970" },
                    { 1878, "Ottergem ERPE-MERE", "9420" },
                    { 1879, "Ottignies OTTIGNIES-LOUVAIN-LA-NEUVE", "1340" },
                    { 1880, "OTTIGNIES-LOUVAIN-LA-NEUVE OTTIGNIES-LOUVAIN-LA-NEUVE", "1340" },
                    { 1881, "OUD-HEVERLEE OUD-HEVERLEE", "3050" },
                    { 1882, "OUD-TURNHOUT OUD-TURNHOUT", "2360" },
                    { 1883, "Oudegem DENDERMONDE", "9200" },
                    { 1884, "Oudekapelle DIKSMUIDE", "8600" },
                    { 1885, "OUDENAARDE OUDENAARDE", "9700" },
                    { 1877, "Ottenburg HULDENBERG", "3040" },
                    { 1886, "Oudenaken SINT-PIETERS-LEEUW", "1600" },
                    { 1888, "OUDERGEM OUDERGEM", "1160" },
                    { 1889, "OUDSBERGEN OUDSBERGEN", "3670" },
                    { 1890, "OUFFET OUFFET", "4590" },
                    { 1891, "Ougr�e SERAING", "4102" },
                    { 1892, "OUPEYE OUPEYE", "4680" },
                    { 1893, "Outer NINOVE", "9406" },
                    { 1894, "Outgaarden HOEGAARDEN", "3321" },
                    { 1895, "Outrelouxhe MODAVE", "4577" },
                    { 1887, "OUDENBURG OUDENBURG", "8460" },
                    { 1896, "Outrijve AVELGEM", "8582" },
                    { 1876, "Otrange OREYE", "4360" },
                    { 1874, "Oteppe BURDINNE", "4210" },
                    { 1856, "Oppuurs PUURS-SINT-AMANDS", "2890" },
                    { 1857, "Opvelp BIERBEEK", "3360" },
                    { 1858, "OPWIJK OPWIJK", "1745" },
                    { 1859, "Orbais PERWEZ", "1360" },
                    { 1860, "Orchimont VRESSE-SUR-SEMOIS", "5550" },
                    { 1861, "Orcq TOURNAI", "7501" },
                    { 1862, "Ordingen SINT-TRUIDEN", "3800" },
                    { 1863, "Oret METTET", "5640" },
                    { 1875, "Oth�e AWANS", "4340" },
                    { 1864, "OREYE OREYE", "4360" },
                    { 1866, "Ormeignies ATH", "7802" },
                    { 1867, "ORP-JAUCHE ORP-JAUCHE", "1350" },
                    { 1868, "Orp-Le-Grand ORP-JAUCHE", "1350" },
                    { 1869, "Orroir MONT-DE-L'ENCLUS", "7750" },
                    { 1870, "Orsmaal-Gussenhoven LINTER", "3350" },
                    { 1871, "Ortho LA ROCHE-EN-ARDENNE", "6983" },
                    { 1872, "Ostiches ATH", "7804" },
                    { 1873, "Otegem ZWEVEGEM", "8553" },
                    { 1865, "Orgeo BERTRIX", "6880" },
                    { 1855, "Opprebais INCOURT", "1315" },
                    { 1897, "Ouwegem KRUISEM", "9750" },
                    { 1899, "Overhespen LINTER", "3350" },
                    { 1922, "Pellenberg LUBBEEK", "3212" },
                    { 1923, "PELT PELT", "3900" },
                    { 1924, "PEPINGEN PEPINGEN", "1670" },
                    { 1925, "PEPINSTER PEPINSTER", "4860" },
                    { 1926, "Perk STEENOKKERZEEL", "1820" },
                    { 1927, "P�ronnes-Lez-Antoing ANTOING", "7640" },
                    { 1928, "P�ronnes-Lez-Binche BINCHE", "7134" },
                    { 1929, "P�RUWELZ P�RUWELZ", "7600" },
                    { 1921, "Pellaines LINCENT", "4287" },
                    { 1930, "Pervijze DIKSMUIDE", "8600" },
                    { 1932, "Perwez-Haillot OHEY", "5352" },
                    { 1933, "Pesche COUVIN", "5660" },
                    { 1934, "Pessoux CINEY", "5590" },
                    { 1935, "Petegem-Aan-De-Leie DEINZE", "9800" },
                    { 1936, "Petegem-Aan-De-Schelde WORTEGEM-PETEGEM", "9790" },
                    { 1937, "P�tigny COUVIN", "5660" },
                    { 1938, "Petit-Fays BI�VRE", "5555" },
                    { 1939, "Petit-Hallet HANNUT", "4280" },
                    { 1931, "PERWEZ PERWEZ", "1360" },
                    { 1898, "Overboelare GERAARDSBERGEN", "9500" },
                    { 1920, "Peissant ESTINNES", "7120" },
                    { 1918, "PECQ PECQ", "7740" },
                    { 1900, "OVERIJSE OVERIJSE", "3090" },
                    { 1901, "Overmere BERLARE", "9290" },
                    { 1902, "Overpelt PELT", "3900" },
                    { 1903, "Overrepen TONGEREN", "3700" },
                    { 1904, "Overwinden LANDEN", "3400" },
                    { 1905, "Paal BERINGEN", "3583" },
                    { 1906, "Paifve JUPRELLE", "4452" },
                    { 1907, "Pailhe CLAVIER", "4560" },
                    { 1919, "PEER PEER", "3990" },
                    { 1908, "PALISEUL PALISEUL", "6850" },
                    { 1910, "Papignies LESSINES", "7861" },
                    { 1911, "Parike BRAKEL", "9661" },
                    { 1912, "Parlement de la communaut� fran�aise Parlement de la communaut� fran�aise", "1012" },
                    { 1913, "Parlement Wallon Parlement Wallon", "5012" },
                    { 1914, "Passendale ZONNEBEKE", "8980" },
                    { 1915, "Patignies GEDINNE", "5575" },
                    { 1916, "P�turages COLFONTAINE", "7340" },
                    { 1917, "Paulatem ZWALM", "9630" },
                    { 1909, "Pamel ROOSDAAL", "1760" },
                    { 1940, "Petit-Rechain VERVIERS", "4800" },
                    { 1854, "Opont PALISEUL", "6852" },
                    { 1852, "Oplinter TIENEN", "3300" },
                    { 1790, "Oeren ALVERINGEM", "8690" },
                    { 1791, "Oeselgem DENTERGEM", "8720" },
                    { 1792, "Oetingen GOOIK", "1755" },
                    { 1793, "Oeudeghien FRASNES-LEZ-ANVAING", "7911" },
                    { 1794, "Oevel WESTERLO", "2260" },
                    { 1795, "Offagne PALISEUL", "6850" },
                    { 1796, "Office Exchange Brussels Airport Remailing Office Exchange Brussels Airport Remailing", "1934" },
                    { 1797, "Ogy LESSINES", "7862" },
                    { 1789, "Oelegem RANST", "2520" },
                    { 1798, "Ohain LASNE", "1380" },
                    { 1800, "Oignies-En-Thi�rache VIROINVAL", "5670" },
                    { 1801, "Oisquercq TUBIZE", "1480" },
                    { 1802, "Oizy BI�VRE", "5555" },
                    { 1803, "Okegem NINOVE", "9400" },
                    { 1804, "OLEN OLEN", "2250" },
                    { 1805, "Oleye WAREMME", "4300" },
                    { 1806, "Ollignies LESSINES", "7866" },
                    { 1807, "Olloy-Sur-Viroin VIROINVAL", "5670" },
                    { 1799, "OHEY OHEY", "5350" },
                    { 1808, "Olmen BALEN", "2491" },
                    { 1788, "Oekene ROESELARE", "8800" },
                    { 1786, "Odeur CRISN�E", "4367" },
                    { 1768, "Nokere KRUISEM", "9771" },
                    { 1769, "Nollevaux PALISEUL", "6851" },
                    { 1770, "Noorderwijk HERENTALS", "2200" },
                    { 1771, "Noordschote LO-RENINGE", "8647" },
                    { 1772, "Nossegem ZAVENTEM", "1930" },
                    { 1773, "Nothomb ATTERT", "6717" },
                    { 1774, "Nouvelles MONS", "7022" },
                    { 1775, "Noville FEXHE-LE-HAUT-CLOCHER", "4347" },
                    { 1787, "Oedelem BEERNEM", "8730" },
                    { 1776, "Noville BASTOGNE", "6600" },
                    { 1778, "Noville-Sur-Mehaigne EGHEZ�E", "5310" },
                    { 1779, "Nukerke MAARKEDAL", "9681" },
                    { 1780, "Obaix PONT-�-CELLES", "6230" },
                    { 1781, "Obigies PECQ", "7743" },
                    { 1782, "Obourg MONS", "7034" },
                    { 1783, "Ochamps LIBIN", "6890" },
                    { 1784, "Ocquier CLAVIER", "4560" },
                    { 1785, "Odeigne MANHAY", "6960" },
                    { 1777, "Noville-Les-Bois FERNELMONT", "5380" },
                    { 1853, "Opoeteren MAASEIK", "3680" },
                    { 1809, "OLNE OLNE", "4877" },
                    { 1811, "Omal GEER", "4252" },
                    { 1834, "OOSTKAMP OOSTKAMP", "8020" },
                    { 1835, "Oostkerke DAMME", "8340" },
                    { 1836, "Oostkerke DIKSMUIDE", "8600" },
                    { 1837, "Oostmalle MALLE", "2390" },
                    { 1838, "Oostnieuwkerke STADEN", "8840" },
                    { 1839, "OOSTROZEBEKE OOSTROZEBEKE", "8780" },
                    { 1840, "Oostvleteren VLETEREN", "8640" },
                    { 1841, "Oostwinkel LIEVEGEM", "9931" },
                    { 1833, "Oostham HAM", "3945" },
                    { 1842, "Opbrakel BRAKEL", "9660" },
                    { 1844, "Opglabbeek OUDSBERGEN", "3660" },
                    { 1845, "Opgrimbie MAASMECHELEN", "3630" },
                    { 1846, "Ophain-Bois-Seigneur-Isaac BRAINE-L'ALLEUD", "1421" },
                    { 1847, "Ophasselt GERAARDSBERGEN", "9500" },
                    { 1848, "Opheers HEERS", "3870" },
                    { 1849, "Opheylissem H�L�CINE", "1357" },
                    { 1850, "Ophoven KINROOI", "3640" },
                    { 1851, "Opitter BREE", "3960" },
                    { 1843, "Opdorp BUGGENHOUT", "9255" },
                    { 1810, "Olsene ZULTE", "9870" },
                    { 1832, "OOSTERZELE OOSTERZELE", "9860" },
                    { 1830, "Oosteeklo ASSENEDE", "9968" },
                    { 1812, "Ombret AMAY", "4540" },
                    { 1813, "Omez�e PHILIPPEVILLE", "5600" },
                    { 1814, "On MARCHE-EN-FAMENNE", "6900" },
                    { 1815, "ONHAYE ONHAYE", "5520" },
                    { 1816, "Onkerzele GERAARDSBERGEN", "9500" },
                    { 1817, "Onnezies HONNELLES", "7387" },
                    { 1818, "Onoz JEMEPPE-SUR-SAMBRE", "5190" },
                    { 1819, "Onze-Lieve-Vrouw-Lombeek ROOSDAAL", "1760" },
                    { 1831, "OOSTENDE OOSTENDE", "8400" },
                    { 1820, "Onze-Lieve-Vrouw-Waver SINT-KATELIJNE-WAVER", "2861" },
                    { 1822, "Ooike OUDENAARDE", "9700" },
                    { 1823, "Ooike WORTEGEM-PETEGEM", "9790" },
                    { 1824, "Oombergen SINT-LIEVENS-HOUTEM", "9520" },
                    { 1825, "Oombergen ZOTTEGEM", "9620" },
                    { 1826, "Oorbeek TIENEN", "3300" },
                    { 1827, "Oordegem LEDE", "9340" },
                    { 1828, "Oostakker GENT", "9041" },
                    { 1829, "Oostduinkerke KOKSIJDE", "8670" },
                    { 1821, "Ooigem WIELSBEKE", "8710" },
                    { 1941, "Petit-Roeulx-Lez-Braine BRAINE-LE-COMTE", "7090" },
                    { 1942, "Petit-Roeulx-Lez-Nivelles SENEFFE", "7181" },
                    { 1943, "Petit-Thier VIELSALM", "6692" },
                    { 2055, "Rijmenam BONHEIDEN", "2820" },
                    { 2056, "Riksingen TONGEREN", "3700" },
                    { 2057, "Rillaar AARSCHOT", "3202" },
                    { 2058, "Rivi�re PROFONDEVILLE", "5170" },
                    { 2059, "RIXENSART RIXENSART", "1330" },
                    { 2060, "Robechies CHIMAY", "6460" },
                    { 2061, "Robelmont MEIX-DEVANT-VIRTON", "6769" },
                    { 2062, "Robertville WEISMES", "4950" },
                    { 2054, "Rijkhoven BILZEN", "3740" },
                    { 2063, "Roborst ZWALM", "9630" },
                    { 2065, "Rochehaut BOUILLON", "6830" },
                    { 2066, "Rocherath B�LLINGEN", "4761" },
                    { 2067, "Roclenge-Sur-Geer BASSENGE", "4690" },
                    { 2068, "Rocourt LI�GE", "4000" },
                    { 2069, "Roesbrugge-Haringe POPERINGE", "8972" },
                    { 2070, "ROESELARE ROESELARE", "8800" },
                    { 2071, "Rogn�e WALCOURT", "5651" },
                    { 2072, "Roisin HONNELLES", "7387" },
                    { 2064, "ROCHEFORT ROCHEFORT", "5580" },
                    { 2073, "Roksem OUDENBURG", "8460" },
                    { 2053, "RIJKEVORSEL RIJKEVORSEL", "2310" },
                    { 2051, "Ri�zes CHIMAY", "6464" },
                    { 2033, "Remersdaal VOEREN", "3791" },
                    { 2034, "REMICOURT REMICOURT", "4350" },
                    { 2035, "RENDEUX RENDEUX", "6987" },
                    { 2036, "Reninge LO-RENINGE", "8647" },
                    { 2037, "Reningelst POPERINGE", "8970" },
                    { 2038, "Renlies BEAUMONT", "6500" },
                    { 2039, "Reppel BOCHOLT", "3950" },
                    { 2040, "Ressaix BINCHE", "7134" },
                    { 2052, "Rijkel BORGLOON", "3840" },
                    { 2041, "Ressegem HERZELE", "9551" },
                    { 2043, "RETIE RETIE", "2470" },
                    { 2044, "Retinne FL�RON", "4621" },
                    { 2045, "Reuland BURG-REULAND", "4790" },
                    { 2046, "R�ves LES BONS VILLERS", "6210" },
                    { 2047, "Rhisnes LA BRUY�RE", "5080" },
                    { 2048, "Richelle VIS�", "4600" },
                    { 2049, "RIEMST RIEMST", "3770" },
                    { 2050, "Rienne GEDINNE", "5575" },
                    { 2042, "Resteigne TELLIN", "6927" },
                    { 2032, "Remagne LIBRAMONT-CHEVIGNY", "6800" },
                    { 2074, "Rollegem KORTRIJK", "8510" },
                    { 2076, "Roloux FEXHE-LE-HAUT-CLOCHER", "4347" },
                    { 2099, "Rouvreux SPRIMONT", "4140" },
                    { 2100, "ROUVROY ROUVROY", "6767" },
                    { 2101, "Roux CHARLEROI", "6044" },
                    { 2102, "Roux-Miroir INCOURT", "1315" },
                    { 2103, "Roy MARCHE-EN-FAMENNE", "6900" },
                    { 2104, "Rozebeke ZWALM", "9630" },
                    { 2105, "RTBF RTBF", "1044" },
                    { 2106, "RTL-TVI RTL-TVI", "1033" },
                    { 2098, "Rouveroy ESTINNES", "7120" },
                    { 2107, "Ruddervoorde OOSTKAMP", "8020" },
                    { 2109, "Ruien KLUISBERGEN", "9690" },
                    { 2110, "Ruisbroek SINT-PIETERS-LEEUW", "1601" },
                    { 2111, "Ruisbroek PUURS-SINT-AMANDS", "2870" },
                    { 2112, "RUISELEDE RUISELEDE", "8755" },
                    { 2113, "Rukkelingen-Loon HEERS", "3870" },
                    { 2114, "Rulles HABAY", "6724" },
                    { 2115, "Rumbeke ROESELARE", "8800" },
                    { 2116, "RUMES RUMES", "7610" },
                    { 2108, "Ruette VIRTON", "6760" },
                    { 2075, "Rollegem-Kapelle LEDEGEM", "8880" },
                    { 2097, "Roucourt P�RUWELZ", "7601" },
                    { 2095, "Rotheux-Rimi�re NEUPR�", "4120" },
                    { 2077, "Roly PHILIPPEVILLE", "5600" },
                    { 2078, "Romedenne PHILIPPEVILLE", "5600" },
                    { 2079, "Romer�e DOISCHE", "5680" },
                    { 2080, "Romershoven HOESELT", "3730" },
                    { 2081, "Roms�e FL�RON", "4624" },
                    { 2082, "Rongy BRUNEHAUT", "7623" },
                    { 2083, "Ronqui�res BRAINE-LE-COMTE", "7090" },
                    { 2084, "RONSE RONSE", "9600" },
                    { 2096, "ROTSELAAR ROTSELAAR", "3110" },
                    { 2085, "Ronsele LIEVEGEM", "9932" },
                    { 2087, "ROOSDAAL ROOSDAAL", "1760" },
                    { 2088, "Ros�e FLORENNES", "5620" },
                    { 2089, "Roselies AISEAU-PRESLES", "6250" },
                    { 2090, "Rosi�res RIXENSART", "1331" },
                    { 2091, "Rosmeer BILZEN", "3740" },
                    { 2092, "Rosoux-Crenwick BERLOZ", "4257" },
                    { 2093, "Rossignol TINTIGNY", "6730" },
                    { 2094, "Rotem DILSEN-STOKKEM", "3650" },
                    { 2086, "Roosbeek BOUTERSEM", "3370" },
                    { 2031, "Relegem ASSE", "1731" },
                    { 2030, "Rekkem MENEN", "8930" },
                    { 2029, "Rekem LANAKEN", "3621" },
                    { 1966, "Pommeroeul BERNISSART", "7322" },
                    { 1967, "Pondr�me BEAURAING", "5574" },
                    { 1968, "PONT-�-CELLES PONT-�-CELLES", "6230" },
                    { 1969, "Pont-De-Loup AISEAU-PRESLES", "6250" },
                    { 1970, "Pontillas FERNELMONT", "5380" },
                    { 1971, "POPERINGE POPERINGE", "8970" },
                    { 1972, "Poppel RAVELS", "2382" },
                    { 1973, "Popuelles CELLES", "7760" },
                    { 1965, "Pollinkhove LO-RENINGE", "8647" },
                    { 1974, "Porcheresse HAVELANGE", "5370" },
                    { 1976, "Postcheque Postcheque", "1100" },
                    { 1977, "Pottes CELLES", "7760" },
                    { 1978, "Poucet HANNUT", "4280" },
                    { 1979, "Poulseur COMBLAIN-AU-PONT", "4171" },
                    { 1980, "Poupehan BOUILLON", "6830" },
                    { 1981, "Pousset REMICOURT", "4350" },
                    { 1982, "Presgaux COUVIN", "5660" },
                    { 1983, "Presles AISEAU-PRESLES", "6250" },
                    { 1975, "Porcheresse DAVERDISSE", "6929" },
                    { 1984, "PROFONDEVILLE PROFONDEVILLE", "5170" },
                    { 1964, "Polleur THEUX", "4910" },
                    { 1962, "Pollare NINOVE", "9401" },
                    { 1944, "Petite-Chapelle COUVIN", "5660" },
                    { 1945, "Peutie VILVOORDE", "1800" },
                    { 1946, "PHILIPPEVILLE PHILIPPEVILLE", "5600" },
                    { 1947, "Pi�ton CHAPELLE-LEZ-HERLAIMONT", "7160" },
                    { 1948, "Pi�train JODOIGNE", "1370" },
                    { 1949, "Pi�trebais INCOURT", "1315" },
                    { 1950, "Pipaix LEUZE-EN-HAINAUT", "7904" },
                    { 1951, "Piringen TONGEREN", "3700" },
                    { 1963, "Polleur VERVIERS", "4800" },
                    { 1952, "Pironchamps FARCIENNES", "6240" },
                    { 1954, "Plainevaux NEUPR�", "4122" },
                    { 1955, "Plancenoit LASNE", "1380" },
                    { 1956, "Ploegsteert KOMEN-WAASTEN", "7782" },
                    { 1957, "PLOMBI�RES PLOMBI�RES", "4850" },
                    { 1958, "Poederlee LILLE", "2275" },
                    { 1959, "Poeke AALTER", "9880" },
                    { 1960, "Poelkapelle LANGEMARK-POELKAPELLE", "8920" },
                    { 1961, "Poesele DEINZE", "9850" },
                    { 1953, "PITTEM PITTEM", "8740" },
                    { 1985, "Proven POPERINGE", "8972" },
                    { 1986, "Pry WALCOURT", "5650" },
                    { 1987, "Pulderbos ZANDHOVEN", "2242" },
                    { 2011, "Ramelot TINLOT", "4557" },
                    { 2012, "RAMILLIES RAMILLIES", "1367" },
                    { 2013, "Ramsdonk KAPELLE-OP-DEN-BOS", "1880" },
                    { 2014, "Ramsel HERSELT", "2230" },
                    { 2015, "Ramskapelle KNOKKE-HEIST", "8301" },
                    { 2016, "Ramskapelle NIEUWPOORT", "8620" },
                    { 2017, "Rance SIVRY-RANCE", "6470" },
                    { 2018, "Ransart CHARLEROI", "6043" },
                    { 2010, "Ramegnies-Chin TOURNAI", "7520" },
                    { 2019, "Ransberg KORTENAKEN", "3470" },
                    { 2021, "RAVELS RAVELS", "2380" },
                    { 2022, "Rebaix ATH", "7804" },
                    { 2023, "REBECQ REBECQ", "1430" },
                    { 2024, "Rebecq-Rognon REBECQ", "1430" },
                    { 2025, "Recht SANKT-VITH", "4780" },
                    { 2026, "Recogne LIBRAMONT-CHEVIGNY", "6800" },
                    { 2027, "Redu LIBIN", "6890" },
                    { 2028, "Reet RUMST", "2840" },
                    { 2020, "RANST RANST", "2520" },
                    { 2009, "Ramegnies BELOEIL", "7971" },
                    { 2008, "Rahier STOUMONT", "4987" },
                    { 2007, "Ragnies THUIN", "6532" },
                    { 1988, "Pulle ZANDHOVEN", "2243" },
                    { 1989, "Purnode YVOIR", "5530" },
                    { 1990, "Pussemange VRESSE-SUR-SEMOIS", "5550" },
                    { 1991, "PUTTE PUTTE", "2580" },
                    { 1992, "Puurs PUURS-SINT-AMANDS", "2870" },
                    { 1993, "PUURS-SINT-AMANDS PUURS-SINT-AMANDS", "2870" },
                    { 1994, "QUAREGNON QUAREGNON", "7390" },
                    { 1995, "Quartes TOURNAI", "7540" },
                    { 1996, "Quenast REBECQ", "1430" },
                    { 1997, "Queue-Du-Bois BEYNE-HEUSAY", "4610" },
                    { 1998, "Quevaucamps BELOEIL", "7972" },
                    { 1999, "QU�VY QU�VY", "7040" },
                    { 2000, "Qu�vy-Le-Grand QU�VY", "7040" },
                    { 2001, "Qu�vy-Le-Petit QU�VY", "7040" },
                    { 2002, "QUI�VRAIN QUI�VRAIN", "7380" },
                    { 2003, "Raad van de Vlaamse Gemeenschapscommissie Raad van de Vlaamse Gemeenschapscommissie", "1006" },
                    { 2004, "Rachecourt AUBANGE", "6792" },
                    { 2005, "Racour LINCENT", "4287" },
                    { 2006, "RAEREN RAEREN", "4730" },
                    { 1767, "Noiseux SOMME-LEUZE", "5377" },
                    { 2117, "Rumillies TOURNAI", "7540" },
                    { 1766, "Noirfontaine BOUILLON", "6831" },
                    { 1764, "Noduwez ORP-JAUCHE", "1350" },
                    { 1525, "Maubray ANTOING", "7640" },
                    { 1526, "Maulde TOURNAI", "7534" },
                    { 1527, "Maurage LA LOUVI�RE", "7110" },
                    { 1528, "Maz�e VIROINVAL", "5670" },
                    { 1529, "Mazenzele OPWIJK", "1745" },
                    { 1530, "Mazy GEMBLOUX", "5032" },
                    { 1531, "M�an HAVELANGE", "5372" },
                    { 1532, "MECHELEN MECHELEN", "2800" },
                    { 1524, "Mater OUDENAARDE", "9700" },
                    { 1533, "Mechelen-Aan-De-Maas MAASMECHELEN", "3630" },
                    { 1535, "Meeffe WASSEIGES", "4219" },
                    { 1536, "Meensel-Kiezegem TIELT-WINGE", "3391" },
                    { 1537, "Meer HOOGSTRATEN", "2321" },
                    { 1538, "Meerbeek KORTENBERG", "3078" },
                    { 1539, "Meerbeke NINOVE", "9402" },
                    { 1540, "Meerdonk SINT-GILLIS-WAAS", "9170" },
                    { 1541, "MEERHOUT MEERHOUT", "2450" },
                    { 1542, "Meerle HOOGSTRATEN", "2328" },
                    { 1534, "Mechelen-Bovelingen HEERS", "3870" },
                    { 1543, "Meeswijk MAASMECHELEN", "3630" },
                    { 1523, "Matagne-La-Petite DOISCHE", "5680" },
                    { 1521, "Massenhoven ZANDHOVEN", "2240" },
                    { 1503, "Marcourt RENDEUX", "6987" },
                    { 1504, "Marenne HOTTON", "6990" },
                    { 1505, "Mariakerke GENT", "9030" },
                    { 1506, "Mariekerke BORNEM", "2880" },
                    { 1507, "Mariembourg COUVIN", "5660" },
                    { 1508, "Marilles ORP-JAUCHE", "1350" },
                    { 1509, "Mark EDINGEN", "7850" },
                    { 1510, "Marke KORTRIJK", "8510" },
                    { 1522, "Matagne-La-Grande DOISCHE", "5680" },
                    { 1511, "Markegem DENTERGEM", "8720" },
                    { 1513, "Marquain TOURNAI", "7522" },
                    { 1514, "MARTELANGE MARTELANGE", "6630" },
                    { 1515, "Martenslinde BILZEN", "3742" },
                    { 1516, "Martouzin-Neuville BEAURAING", "5573" },
                    { 1517, "Masbourg NASSOGNE", "6953" },
                    { 1518, "Masnuy-Saint-Jean JURBISE", "7050" },
                    { 1519, "Masnuy-Saint-Pierre JURBISE", "7050" },
                    { 1520, "Massemen WETTEREN", "9230" },
                    { 1512, "Marneffe BURDINNE", "4210" },
                    { 1502, "Marcinelle CHARLEROI", "6001" },
                    { 1544, "Meetkerke ZUIENKERKE", "8377" },
                    { 1546, "Mehaigne EGHEZ�E", "5310" },
                    { 1569, "Membruggen RIEMST", "3770" },
                    { 1570, "Mendonk GENT", "9042" },
                    { 1571, "MENEN MENEN", "8930" },
                    { 1572, "MERBES-LE-CH�TEAU MERBES-LE-CH�TEAU", "6567" },
                    { 1573, "Merbes-Sainte-Marie MERBES-LE-CH�TEAU", "6567" },
                    { 1574, "MERCHTEM MERCHTEM", "1785" },
                    { 1575, "Merdorp HANNUT", "4280" },
                    { 1576, "Mere ERPE-MERE", "9420" },
                    { 1568, "Membre VRESSE-SUR-SEMOIS", "5550" },
                    { 1577, "MERELBEKE MERELBEKE", "9820" },
                    { 1579, "Merkem HOUTHULST", "8650" },
                    { 1580, "Merksem ANTWERPEN", "2170" },
                    { 1581, "MERKSPLAS MERKSPLAS", "2330" },
                    { 1582, "Merlemont PHILIPPEVILLE", "5600" },
                    { 1583, "MESEN MESEN", "8957" },
                    { 1584, "Meslin-L'Ev�que ATH", "7822" },
                    { 1585, "Mesnil-Eglise HOUYET", "5560" },
                    { 1586, "Mesnil-Saint-Blaise HOUYET", "5560" },
                    { 1578, "Merendree DEINZE", "9850" },
                    { 1545, "Meeuwen OUDSBERGEN", "3670" },
                    { 1567, "Membach BAELEN", "4837" },
                    { 1565, "Melsele BEVEREN-WAAS", "9120" },
                    { 1547, "Meigem DEINZE", "9800" },
                    { 1548, "Meilegem ZWALM", "9630" },
                    { 1549, "MEISE MEISE", "1860" },
                    { 1550, "MEIX-DEVANT-VIRTON MEIX-DEVANT-VIRTON", "6769" },
                    { 1551, "Meix-Le-Tige SAINT-L�GER", "6747" },
                    { 1552, "Melden OUDENAARDE", "9700" },
                    { 1553, "Meldert HOEGAARDEN", "3320" },
                    { 1554, "Meldert LUMMEN", "3560" },
                    { 1566, "Melsen MERELBEKE", "9820" },
                    { 1555, "Meldert AALST", "9310" },
                    { 1557, "M�lin JODOIGNE", "1370" },
                    { 1558, "Melkwezer LINTER", "3350" },
                    { 1559, "MELLE MELLE", "9090" },
                    { 1560, "Mellery VILLERS-LA-VILLE", "1495" },
                    { 1561, "Melles TOURNAI", "7540" },
                    { 1562, "Mellet LES BONS VILLERS", "6211" },
                    { 1563, "Mellier L�GLISE", "6860" },
                    { 1564, "Melsbroek STEENOKKERZEEL", "1820" },
                    { 1556, "Melen SOUMAGNE", "4633" },
                    { 1587, "Mespelare DENDERMONDE", "9200" },
                    { 1501, "Marchovelette FERNELMONT", "5380" },
                    { 1499, "MARCHIN MARCHIN", "4570" },
                    { 1437, "Longlier NEUFCH�TEAU", "6840" },
                    { 1438, "Longueville CHAUMONT-GISTOUX", "1325" },
                    { 1439, "Longvilly BASTOGNE", "6600" },
                    { 1440, "LONTZEN LONTZEN", "4710" },
                    { 1441, "Lonz�e GEMBLOUX", "5030" },
                    { 1442, "Loonbeek HULDENBERG", "3040" },
                    { 1443, "Loppem ZEDELGEM", "8210" },
                    { 1444, "Lorc� STOUMONT", "4987" },
                    { 1436, "Longchamps BERTOGNE", "6688" },
                    { 1445, "Lot BEERSEL", "1651" },
                    { 1447, "Louette-Saint-Denis GEDINNE", "5575" },
                    { 1448, "Louette-Saint-Pierre GEDINNE", "5575" },
                    { 1449, "Loupoigne GENAPPE", "1471" },
                    { 1450, "Louvain-La-Neuve OTTIGNIES-LOUVAIN-LA-NEUVE", "1348" },
                    { 1451, "Louveign� SPRIMONT", "4141" },
                    { 1452, "Louveign� AYWAILLE", "4920" },
                    { 1453, "Lovendegem LIEVEGEM", "9920" },
                    { 1454, "Lovenjoel BIERBEEK", "3360" },
                    { 1446, "Lotenhulle AALTER", "9880" },
                    { 1455, "Loverval GERPINNES", "6280" },
                    { 1435, "Longchamps EGHEZ�E", "5310" },
                    { 1433, "Loncin ANS", "4431" },
                    { 1415, "Lissewege BRUGGE", "8380" },
                    { 1416, "Lives-Sur-Meuse NAMUR", "5101" },
                    { 1417, "Lixhe VIS�", "4600" },
                    { 1418, "Lo LO-RENINGE", "8647" },
                    { 1419, "LO-RENINGE LO-RENINGE", "8647" },
                    { 1420, "LOBBES LOBBES", "6540" },
                    { 1421, "LOCHRISTI LOCHRISTI", "9080" },
                    { 1422, "Lodelinsart CHARLEROI", "6042" },
                    { 1434, "LONDERZEEL LONDERZEEL", "1840" },
                    { 1423, "Loenhout WUUSTWEZEL", "2990" },
                    { 1425, "LOKEREN LOKEREN", "9160" },
                    { 1426, "Loksbergen HALEN", "3545" },
                    { 1427, "Lombardsijde MIDDELKERKE", "8434" },
                    { 1428, "Lombise LENS", "7870" },
                    { 1429, "LOMMEL LOMMEL", "3920" },
                    { 1430, "Lommersweiler SANKT-VITH", "4783" },
                    { 1431, "Lompret CHIMAY", "6463" },
                    { 1432, "Lomprez WELLIN", "6924" },
                    { 1424, "Loker HEUVELLAND", "8958" },
                    { 1500, "Marchipont HONNELLES", "7387" },
                    { 1456, "Loyers NAMUR", "5101" },
                    { 1458, "Luingne MOESKROEN", "7700" },
                    { 1481, "Malderen LONDERZEEL", "1840" },
                    { 1482, "Malempr� MANHAY", "6960" },
                    { 1483, "Mal�ves-Sainte-Marie-Wastinnes PERWEZ", "1360" },
                    { 1484, "MALLE MALLE", "2390" },
                    { 1485, "MALMEDY MALMEDY", "4960" },
                    { 1486, "Malonne NAMUR", "5020" },
                    { 1487, "Malvoisin GEDINNE", "5575" },
                    { 1488, "MANAGE MANAGE", "7170" },
                    { 1480, "MALDEGEM MALDEGEM", "9990" },
                    { 1489, "Manderfeld B�LLINGEN", "4760" },
                    { 1491, "Mannekensvere MIDDELKERKE", "8433" },
                    { 1492, "Maransart LASNE", "1380" },
                    { 1493, "Marbais VILLERS-LA-VILLE", "1495" },
                    { 1494, "Marbaix HAM-SUR-HEURE", "6120" },
                    { 1495, "MARCHE-EN-FAMENNE MARCHE-EN-FAMENNE", "6900" },
                    { 1496, "Marche-Les-Dames NAMUR", "5024" },
                    { 1497, "Marche-Lez-Ecaussinnes ECAUSSINNES", "7190" },
                    { 1498, "Marchienne-Au-Pont CHARLEROI", "6030" },
                    { 1490, "MANHAY MANHAY", "6960" },
                    { 1457, "LUBBEEK LUBBEEK", "3210" },
                    { 1479, "Mal TONGEREN", "3700" },
                    { 1477, "Maissin PALISEUL", "6852" },
                    { 1459, "LUMMEN LUMMEN", "3560" },
                    { 1460, "Lustin PROFONDEVILLE", "5170" },
                    { 1461, "Luttre PONT-�-CELLES", "6238" },
                    { 1462, "Maarke-Kerkem MAARKEDAL", "9680" },
                    { 1463, "MAARKEDAL MAARKEDAL", "9680" },
                    { 1464, "MAASEIK MAASEIK", "3680" },
                    { 1465, "MAASMECHELEN MAASMECHELEN", "3630" },
                    { 1466, "Mabompr� HOUFFALIZE", "6663" },
                    { 1478, "Maizeret ANDENNE", "5300" },
                    { 1467, "MACHELEN MACHELEN", "1830" },
                    { 1469, "Macon MOMIGNIES", "6591" },
                    { 1470, "Macquenoise MOMIGNIES", "6593" },
                    { 1471, "Maffe HAVELANGE", "5374" },
                    { 1472, "Maffle ATH", "7810" },
                    { 1473, "Magn�e FL�RON", "4623" },
                    { 1474, "Maillen ASSESSE", "5330" },
                    { 1475, "Mainvault ATH", "7812" },
                    { 1476, "Maisi�res MONS", "7020" },
                    { 1468, "Machelen ZULTE", "9870" },
                    { 1588, "MESSANCY MESSANCY", "6780" },
                    { 1589, "Messelbroek SCHERPENHEUVEL-ZICHEM", "3272" },
                    { 1590, "Mesvin MONS", "7022" },
                    { 1702, "NASSOGNE NASSOGNE", "6950" },
                    { 1703, "NATO NATO", "1110" },
                    { 1704, "Natoye HAMOIS", "5360" },
                    { 1705, "NAZARETH NAZARETH", "9810" },
                    { 1706, "N�chin ESTAIMPUIS", "7730" },
                    { 1707, "Neder-Over-Heembeek BRUSSEL", "1120" },
                    { 1708, "Nederboelare GERAARDSBERGEN", "9500" },
                    { 1709, "Nederbrakel BRAKEL", "9660" },
                    { 1701, "Naom� BI�VRE", "5555" },
                    { 1710, "Nederename OUDENAARDE", "9700" },
                    { 1712, "Nederokkerzeel KAMPENHOUT", "1910" },
                    { 1713, "Nederzwalm-Hermelgem ZWALM", "9636" },
                    { 1714, "Neerglabbeek OUDSBERGEN", "3670" },
                    { 1715, "Neerharen LANAKEN", "3620" },
                    { 1716, "Neerhespen LINTER", "3350" },
                    { 1717, "Neerheylissem H�L�CINE", "1357" },
                    { 1718, "Neerijse HULDENBERG", "3040" },
                    { 1719, "Neerlanden LANDEN", "3404" },
                    { 1711, "Nederhasselt NINOVE", "9400" },
                    { 1720, "Neerlinter LINTER", "3350" },
                    { 1700, "Naninne NAMUR", "5100" },
                    { 1698, "NAMUR NAMUR", "5000" },
                    { 1680, "Mouzaive VRESSE-SUR-SEMOIS", "5550" },
                    { 1681, "Moxhe HANNUT", "4280" },
                    { 1682, "Mozet GESVES", "5340" },
                    { 1683, "Muizen MECHELEN", "2812" },
                    { 1684, "Muizen GINGELOM", "3891" },
                    { 1685, "Mullem OUDENAARDE", "9700" },
                    { 1686, "Munkzwalm ZWALM", "9630" },
                    { 1687, "Muno FLORENVILLE", "6820" },
                    { 1699, "NANDRIN NANDRIN", "4550" },
                    { 1688, "Munsterbilzen BILZEN", "3740" },
                    { 1690, "MUSSON MUSSON", "6750" },
                    { 1691, "Mussy-La-Ville MUSSON", "6750" },
                    { 1692, "My FERRI�RES", "4190" },
                    { 1693, "Naast SOIGNIES", "7062" },
                    { 1694, "Nadrin HOUFFALIZE", "6660" },
                    { 1695, "Nafraiture VRESSE-SUR-SEMOIS", "5550" },
                    { 1696, "Nalinnes HAM-SUR-HEURE", "6120" },
                    { 1697, "Nam�che ANDENNE", "5300" },
                    { 1689, "Munte MERELBEKE", "9820" },
                    { 1679, "Moustier-Sur-Sambre JEMEPPE-SUR-SAMBRE", "5190" },
                    { 1721, "Neeroeteren MAASEIK", "3680" },
                    { 1723, "Neerrepen TONGEREN", "3700" },
                    { 1746, "NIEUWERKERKEN NIEUWERKERKEN", "3850" },
                    { 1747, "Nieuwerkerken AALST", "9320" },
                    { 1748, "Nieuwkapelle DIKSMUIDE", "8600" },
                    { 1749, "Nieuwkerke HEUVELLAND", "8950" },
                    { 1750, "Nieuwkerken-Waas SINT-NIKLAAS", "9100" },
                    { 1751, "Nieuwmunster ZUIENKERKE", "8377" },
                    { 1752, "NIEUWPOORT NIEUWPOORT", "8620" },
                    { 1753, "Nieuwrode HOLSBEEK", "3221" },
                    { 1745, "Nieuwenrode KAPELLE-OP-DEN-BOS", "1880" },
                    { 1754, "NIJLEN NIJLEN", "2560" },
                    { 1756, "Nimy MONS", "7020" },
                    { 1757, "NINOVE NINOVE", "9400" },
                    { 1758, "Nismes VIROINVAL", "5670" },
                    { 1759, "NIVELLES NIVELLES", "1400" },
                    { 1760, "Niverl�e DOISCHE", "5680" },
                    { 1761, "Nives VAUX-SUR-S�RE", "6640" },
                    { 1762, "Nobressart ATTERT", "6717" },
                    { 1763, "Nodebais BEAUVECHAIN", "1320" },
                    { 1755, "Nil-Saint-Vincent-Saint-Martin WALHAIN", "1457" },
                    { 1722, "Neerpelt PELT", "3910" },
                    { 1744, "Nieuwenhove GERAARDSBERGEN", "9506" },
                    { 1742, "Niel-Bij-As AS", "3668" },
                    { 1724, "Neervelp BOUTERSEM", "3370" },
                    { 1725, "Neerwaasten KOMEN-WAASTEN", "7784" },
                    { 1726, "Neerwinden LANDEN", "3400" },
                    { 1727, "Neigem NINOVE", "9403" },
                    { 1728, "Nerem TONGEREN", "3700" },
                    { 1729, "Nessonvaux TROOZ", "4870" },
                    { 1730, "Nethen GREZ-DOICEAU", "1390" },
                    { 1731, "Nettinne SOMME-LEUZE", "5377" },
                    { 1743, "Niel-Bij-Sint-Truiden GINGELOM", "3890" },
                    { 1732, "Neu-Moresnet KELMIS", "4721" },
                    { 1734, "NEUFCH�TEAU NEUFCH�TEAU", "6840" },
                    { 1735, "Neufmaison SAINT-GHISLAIN", "7332" },
                    { 1736, "Neufvilles SOIGNIES", "7063" },
                    { 1737, "NEUPR� NEUPR�", "4120" },
                    { 1738, "Neuville PHILIPPEVILLE", "5600" },
                    { 1739, "Neuville-En-Condroz NEUPR�", "4121" },
                    { 1740, "Nevele DEINZE", "9850" },
                    { 1741, "NIEL NIEL", "2845" },
                    { 1733, "Neufch�teau DALHEM", "4608" },
                    { 1678, "Moustier FRASNES-LEZ-ANVAING", "7911" },
                    { 1677, "Mourcourt TOURNAI", "7543" },
                    { 1676, "Moulbaix ATH", "7812" },
                    { 1613, "MOERBEKE-WAAS MOERBEKE-WAAS", "9180" },
                    { 1614, "Moere GISTEL", "8470" },
                    { 1615, "Moerkerke DAMME", "8340" },
                    { 1616, "Moerzeke HAMME", "9220" },
                    { 1617, "MOESKROEN MOESKROEN", "7700" },
                    { 1618, "Moha WANZE", "4520" },
                    { 1619, "Mohiville HAMOIS", "5361" },
                    { 1620, "Moignel�e SAMBREVILLE", "5060" },
                    { 1612, "Moerbeke GERAARDSBERGEN", "9500" },
                    { 1621, "Moircy LIBRAMONT-CHEVIGNY", "6800" },
                    { 1623, "Molenbaix CELLES", "7760" },
                    { 1624, "Molenbeek-Wersbeek BEKKEVOORT", "3461" },
                    { 1625, "Molenbeersel KINROOI", "3640" },
                    { 1626, "Molenstede DIEST", "3294" },
                    { 1627, "Mollem ASSE", "1730" },
                    { 1628, "Momalle REMICOURT", "4350" },
                    { 1629, "MOMIGNIES MOMIGNIES", "6590" },
                    { 1630, "Monceau-En-Ardenne BI�VRE", "5555" },
                    { 1622, "MOL MOL", "2400" },
                    { 1631, "Monceau-Imbrechies MOMIGNIES", "6592" },
                    { 1611, "Moen ZWEVEGEM", "8552" },
                    { 1609, "MODAVE MODAVE", "4577" },
                    { 1591, "Mettekoven HEERS", "3870" },
                    { 1592, "METTET METTET", "5640" },
                    { 1593, "MEULEBEKE MEULEBEKE", "8760" },
                    { 1594, "Meux LA BRUY�RE", "5081" },
                    { 1595, "M�vergnies-Lez-Lens BRUGELETTE", "7942" },
                    { 1596, "Meyerode AMEL", "4770" },
                    { 1597, "Michelbeke BRAKEL", "9660" },
                    { 1598, "Micheroux SOUMAGNE", "4630" },
                    { 1610, "Moelingen VOEREN", "3790" },
                    { 1599, "Middelburg MALDEGEM", "9992" },
                    { 1601, "Mi�cret HAVELANGE", "5376" },
                    { 1602, "Mielen-Boven-Aalst GINGELOM", "3891" },
                    { 1603, "Mignault LE ROEULX", "7070" },
                    { 1604, "Millen RIEMST", "3770" },
                    { 1605, "Milmort HERSTAL", "4041" },
                    { 1606, "Minderhout HOOGSTRATEN", "2322" },
                    { 1607, "Ministerie van het Brussels Hoofdstedelijk Gewest Ministerie van het Brussels Hoofdstedelijk Gewest", "1035" },
                    { 1608, "Mirwart SAINT-HUBERT", "6870" },
                    { 1600, "MIDDELKERKE MIDDELKERKE", "8430" },
                    { 1632, "Monceau-Sur-Sambre CHARLEROI", "6031" },
                    { 1633, "MONS MONS", "7000" },
                    { 1634, "Mons-Lez-Li�ge FL�MALLE", "4400" },
                    { 1658, "Moorsel AALST", "9310" },
                    { 1659, "Moorsele WEVELGEM", "8560" },
                    { 1660, "MOORSLEDE MOORSLEDE", "8890" },
                    { 1661, "Moortsele OOSTERZELE", "9860" },
                    { 1662, "Mopertingen BILZEN", "3740" },
                    { 1663, "Moregem WORTEGEM-PETEGEM", "9790" },
                    { 1664, "Moresnet PLOMBI�RES", "4850" },
                    { 1665, "Morhet VAUX-SUR-S�RE", "6640" },
                    { 1657, "Montzen PLOMBI�RES", "4850" },
                    { 1666, "Morialm� FLORENNES", "5621" },
                    { 1668, "MORLANWELZ MORLANWELZ", "7140" },
                    { 1669, "Morlanwelz-Mariemont MORLANWELZ", "7140" },
                    { 1670, "Mormont EREZ�E", "6997" },
                    { 1671, "Mornimont JEMEPPE-SUR-SAMBRE", "5190" },
                    { 1672, "Mortier BL�GNY", "4670" },
                    { 1673, "Mortroux DALHEM", "4607" },
                    { 1674, "MORTSEL MORTSEL", "2640" },
                    { 1675, "Morville FLORENNES", "5620" },
                    { 1667, "Morkhoven HERENTALS", "2200" },
                    { 1656, "Montroeul-Sur-Haine HENSIES", "7350" },
                    { 1655, "Montroeul-Au-Bois FRASNES-LEZ-ANVAING", "7911" },
                    { 1654, "Montleban GOUVY", "6674" },
                    { 1635, "Monstreux NIVELLES", "1400" },
                    { 1636, "Mont YVOIR", "5530" },
                    { 1637, "Mont HOUFFALIZE", "6661" },
                    { 1638, "MONT-DE-L'ENCLUS MONT-DE-L'ENCLUS", "7750" },
                    { 1639, "Mont-Gauthier ROCHEFORT", "5580" },
                    { 1640, "Mont-Saint-Andr� RAMILLIES", "1367" },
                    { 1641, "Mont-Saint-Aubert TOURNAI", "7542" },
                    { 1642, "MONT-SAINT-GUIBERT MONT-SAINT-GUIBERT", "1435" },
                    { 1643, "Mont-Sainte-Aldegonde MORLANWELZ", "7141" },
                    { 1644, "Mont-Sainte-Genevi�ve LOBBES", "6540" },
                    { 1645, "Mont-Sur-Marchienne CHARLEROI", "6032" },
                    { 1646, "Montbliart SIVRY-RANCE", "6470" },
                    { 1647, "Montegn�e SAINT-NICOLAS", "4420" },
                    { 1648, "Montenaken GINGELOM", "3890" },
                    { 1649, "Montignies-Lez-Lens LENS", "7870" }
                });

            migrationBuilder.InsertData(
                table: "ZipCode",
                columns: new[] { "Id", "City", "Code" },
                values: new object[,]
                {
                    { 1650, "Montignies-Saint-Christophe ERQUELINNES", "6560" },
                    { 1651, "Montignies-Sur-Roc HONNELLES", "7387" },
                    { 1652, "Montignies-Sur-Sambre CHARLEROI", "6061" },
                    { 1653, "MONTIGNY-LE-TILLEUL MONTIGNY-LE-TILLEUL", "6110" },
                    { 1765, "Noirchain FRAMERIES", "7080" },
                    { 2118, "Rummen GEETBETS", "3454" },
                    { 2119, "Rumsdorp LANDEN", "3400" },
                    { 2120, "RUMST RUMST", "2840" },
                    { 2585, "Vodel�e DOISCHE", "5680" },
                    { 2586, "VOEREN VOEREN", "3790" },
                    { 2587, "Vogen�e WALCOURT", "5650" },
                    { 2588, "Volkegem OUDENAARDE", "9700" },
                    { 2589, "Vollezele GALMAARDEN", "1570" },
                    { 2590, "Von�che BEAURAING", "5570" },
                    { 2591, "Voorde NINOVE", "9400" },
                    { 2592, "Voormezele IEPER", "8902" },
                    { 2584, "Vodec�e PHILIPPEVILLE", "5600" },
                    { 2593, "Voort BORGLOON", "3840" },
                    { 2595, "Voroux-Lez-Liers JUPRELLE", "4451" },
                    { 2596, "VORSELAAR VORSELAAR", "2290" },
                    { 2597, "Vorsen GINGELOM", "3890" },
                    { 2598, "VORST VORST", "1190" },
                    { 2599, "Vorst LAAKDAL", "2430" },
                    { 2600, "VOSSELAAR VOSSELAAR", "2350" },
                    { 2601, "Vosselare DEINZE", "9850" },
                    { 2602, "Vossem TERVUREN", "3080" },
                    { 2594, "Voroux-Goreux FEXHE-LE-HAUT-CLOCHER", "4347" },
                    { 2603, "Vottem HERSTAL", "4041" },
                    { 2583, "VLOESBERG VLOESBERG", "7880" },
                    { 2581, "Vlimmeren BEERSE", "2340" },
                    { 2563, "VIROINVAL VIROINVAL", "5670" },
                    { 2564, "VIRTON VIRTON", "6760" },
                    { 2565, "VIS� VIS�", "4600" },
                    { 2566, "Vissenaken TIENEN", "3300" },
                    { 2567, "Vitrine Magique Vitrine Magique", "7511" },
                    { 2568, "Vitrival FOSSES-LA-VILLE", "5070" },
                    { 2569, "Vivegnis OUPEYE", "4683" },
                    { 2570, "Vivy BOUILLON", "6833" },
                    { 2582, "Vlissegem DE HAAN", "8421" },
                    { 2571, "Vlaams Parlement Vlaams Parlement", "1011" },
                    { 2573, "Vlamertinge IEPER", "8908" },
                    { 2574, "Vlekkem ERPE-MERE", "9420" },
                    { 2575, "VLETEREN VLETEREN", "8640" },
                    { 2576, "Vlezenbeek SINT-PIETERS-LEEUW", "1602" },
                    { 2577, "Vliermaal KORTESSEM", "3724" },
                    { 2578, "Vliermaalroot KORTESSEM", "3721" },
                    { 2579, "Vlierzele SINT-LIEVENS-HOUTEM", "9520" },
                    { 2580, "Vlijtingen RIEMST", "3770" },
                    { 2572, "Vladslo DIKSMUIDE", "8600" },
                    { 2562, "Virginal-Samme ITTRE", "1460" },
                    { 2604, "Vrasene BEVEREN-WAAS", "9120" },
                    { 2606, "Vreren TONGEREN", "3700" },
                    { 2629, "WALCOURT WALCOURT", "5650" },
                    { 2630, "Walem MECHELEN", "2800" },
                    { 2631, "WALHAIN WALHAIN", "1457" },
                    { 2632, "Walhain-Saint-Paul WALHAIN", "1457" },
                    { 2633, "Walhorn LONTZEN", "4711" },
                    { 2634, "Walsbets LANDEN", "3401" },
                    { 2635, "Walshoutem LANDEN", "3401" },
                    { 2636, "Waltwilder BILZEN", "3740" },
                    { 2628, "Wakken DENTERGEM", "8720" },
                    { 2637, "Wambeek TERNAT", "1741" },
                    { 2639, "Wandre LI�GE", "4020" },
                    { 2640, "Wanferc�e-Baulet FLEURUS", "6224" },
                    { 2641, "Wange LANDEN", "3400" },
                    { 2642, "Wangenies FLEURUS", "6220" },
                    { 2643, "Wanlin HOUYET", "5564" },
                    { 2644, "Wanne TROIS-PONTS", "4980" },
                    { 2645, "Wannebecq LESSINES", "7861" },
                    { 2646, "Wannegem-Lede KRUISEM", "9772" },
                    { 2638, "Wancennes BEAURAING", "5570" },
                    { 2605, "Vremde BOECHOUT", "2531" },
                    { 2627, "Waillet SOMME-LEUZE", "5377" },
                    { 2625, "Wagnel�e FLEURUS", "6223" },
                    { 2607, "VRESSE-SUR-SEMOIS VRESSE-SUR-SEMOIS", "5550" },
                    { 2608, "Vroenhoven RIEMST", "3770" },
                    { 2609, "VRT VRT", "1043" },
                    { 2610, "VTM VTM", "1818" },
                    { 2611, "Vucht MAASMECHELEN", "3630" },
                    { 2612, "Vurste GAVERE", "9890" },
                    { 2613, "Vyle-Et-Tharoul MARCHIN", "4570" },
                    { 2614, "Waanrode KORTENAKEN", "3473" },
                    { 2626, "Waha MARCHE-EN-FAMENNE", "6900" },
                    { 2615, "Waarbeke GERAARDSBERGEN", "9506" },
                    { 2617, "Waarloos KONTICH", "2550" },
                    { 2618, "Waarmaarde AVELGEM", "8581" },
                    { 2619, "Waarschoot LIEVEGEM", "9950" },
                    { 2620, "Waasmont LANDEN", "3401" },
                    { 2621, "WAASMUNSTER WAASMUNSTER", "9250" },
                    { 2622, "Waasten KOMEN-WAASTEN", "7784" },
                    { 2623, "WACHTEBEKE WACHTEBEKE", "9185" },
                    { 2624, "Wadelincourt BELOEIL", "7971" },
                    { 2616, "Waardamme OOSTKAMP", "8020" },
                    { 2647, "Wansin HANNUT", "4280" },
                    { 2561, "Virelles CHIMAY", "6461" },
                    { 2559, "Vinkem VEURNE", "8630" },
                    { 2497, "Veldwezelt LANAKEN", "3620" },
                    { 2498, "Vellereille-Le-Sec ESTINNES", "7120" },
                    { 2499, "Vellereille-Les-Brayeux ESTINNES", "7120" },
                    { 2500, "Velm SINT-TRUIDEN", "3806" },
                    { 2501, "Velroux GR�CE-HOLLOGNE", "4460" },
                    { 2502, "Veltem-Beisem HERENT", "3020" },
                    { 2503, "Velzeke-Ruddershove ZOTTEGEM", "9620" },
                    { 2504, "Vencimont GEDINNE", "5575" },
                    { 2496, "Veldegem ZEDELGEM", "8210" },
                    { 2505, "Verenigde Vergadering van de Gemeenschappelijke  Verenigde Vergadering van de Gemeenschappelijke ", "1005" },
                    { 2507, "VERLAINE VERLAINE", "4537" },
                    { 2508, "Verl�e HAVELANGE", "5370" },
                    { 2509, "Verrebroek BEVEREN-WAAS", "9130" },
                    { 2510, "Vertrijk BOUTERSEM", "3370" },
                    { 2511, "VERVIERS VERVIERS", "4800" },
                    { 2512, "Vesqueville SAINT-HUBERT", "6870" },
                    { 2513, "Veulen HEERS", "3870" },
                    { 2514, "VEURNE VEURNE", "8630" },
                    { 2506, "Vergnies FROIDCHAPELLE", "6440" },
                    { 2515, "Vezin ANDENNE", "5300" },
                    { 2495, "Velaines CELLES", "7760" },
                    { 2493, "Veerle LAAKDAL", "2431" },
                    { 2475, "Ulbeek WELLEN", "3832" },
                    { 2476, "Upigny EGHEZ�E", "5310" },
                    { 2477, "Ursel AALTER", "9910" },
                    { 2478, "Vaalbeek OUD-HEVERLEE", "3054" },
                    { 2479, "Val-Meer RIEMST", "3770" },
                    { 2480, "Vance ETALLE", "6741" },
                    { 2481, "Varendonk LAAKDAL", "2431" },
                    { 2482, "Varsenare JABBEKE", "8490" },
                    { 2494, "Velaine-Sur-Sambre SAMBREVILLE", "5060" },
                    { 2483, "Vaucelles DOISCHE", "5680" },
                    { 2485, "Vaulx-Lez-Chimay CHIMAY", "6462" },
                    { 2486, "Vaux-Chavanne MANHAY", "6960" },
                    { 2487, "Vaux-Et-Borset VILLERS-LE-BOUILLET", "4530" },
                    { 2488, "Vaux-Lez-Rosi�res VAUX-SUR-S�RE", "6640" },
                    { 2489, "Vaux-Sous-Ch�vremont CHAUDFONTAINE", "4051" },
                    { 2490, "VAUX-SUR-S�RE VAUX-SUR-S�RE", "6640" },
                    { 2491, "Vechmaal HEERS", "3870" },
                    { 2492, "Vedrin NAMUR", "5020" },
                    { 2484, "Vaulx TOURNAI", "7536" },
                    { 2560, "Vinkt DEINZE", "9800" },
                    { 2516, "Vezon TOURNAI", "7538" },
                    { 2518, "Vichte ANZEGEM", "8570" },
                    { 2541, "VILLERS-LA-VILLE VILLERS-LA-VILLE", "1495" },
                    { 2542, "VILLERS-LE-BOUILLET VILLERS-LE-BOUILLET", "4530" },
                    { 2543, "Villers-Le-Gambon PHILIPPEVILLE", "5600" },
                    { 2544, "Villers-Le-Peuplier HANNUT", "4280" },
                    { 2545, "Villers-Le-Temple NANDRIN", "4550" },
                    { 2546, "Villers-Lez-Heest LA BRUY�RE", "5080" },
                    { 2547, "Villers-Notre-Dame ATH", "7812" },
                    { 2548, "Villers-Perwin LES BONS VILLERS", "6210" },
                    { 2540, "Villers-La-Tour CHIMAY", "6460" },
                    { 2549, "Villers-Poterie GERPINNES", "6280" },
                    { 2551, "Villers-Saint-Ghislain MONS", "7031" },
                    { 2552, "Villers-Saint-Sim�on JUPRELLE", "4453" },
                    { 2553, "Villers-Sainte-Gertrude DURBUY", "6941" },
                    { 2554, "Villers-Sur-Lesse ROCHEFORT", "5580" },
                    { 2555, "Villers-Sur-Semois ETALLE", "6740" },
                    { 2556, "VILVOORDE VILVOORDE", "1800" },
                    { 2557, "Vinalmont WANZE", "4520" },
                    { 2558, "Vinderhoute LIEVEGEM", "9921" },
                    { 2550, "Villers-Saint-Amand ATH", "7812" },
                    { 2517, "Viane GERAARDSBERGEN", "9500" },
                    { 2539, "Villers-La-Loue MEIX-DEVANT-VIRTON", "6769" },
                    { 2537, "Villers-L'Ev�que AWANS", "4340" },
                    { 2519, "VIELSALM VIELSALM", "6690" },
                    { 2520, "Viemme FAIMES", "4317" },
                    { 2521, "Viersel ZANDHOVEN", "2240" },
                    { 2522, "Vierset-Barse MODAVE", "4577" },
                    { 2523, "Vierves-Sur-Viroin VIROINVAL", "5670" },
                    { 2524, "Viesville PONT-�-CELLES", "6230" },
                    { 2525, "Vieux-Genappe GENAPPE", "1472" },
                    { 2526, "Vieux-Waleffe VILLERS-LE-BOUILLET", "4530" },
                    { 2538, "Villers-La-Bonne-Eau BASTOGNE", "6600" },
                    { 2527, "Vieuxville FERRI�RES", "4190" },
                    { 2529, "Ville-En-Hesbaye BRAIVES", "4260" },
                    { 2530, "Ville-Pommeroeul BERNISSART", "7322" },
                    { 2531, "Ville-Sur-Haine LE ROEULX", "7070" },
                    { 2532, "Villerot SAINT-GHISLAIN", "7334" },
                    { 2533, "Villers-Aux-Tours ANTHISNES", "4161" },
                    { 2534, "Villers-Deux-Eglises CERFONTAINE", "5630" },
                    { 2535, "Villers-Devant-Orval FLORENVILLE", "6823" },
                    { 2536, "Villers-En-Fagne PHILIPPEVILLE", "5600" },
                    { 2528, "Villance LIBIN", "6890" },
                    { 2648, "WANZE WANZE", "4520" },
                    { 2649, "Wanzele LEDE", "9340" },
                    { 2650, "Warchin TOURNAI", "7548" },
                    { 2762, "Wortel HOOGSTRATEN", "2323" },
                    { 2763, "Woubrechtegem HERZELE", "9550" },
                    { 2764, "Woumen DIKSMUIDE", "8600" },
                    { 2765, "Wulpen KOKSIJDE", "8670" },
                    { 2766, "Wulvergem HEUVELLAND", "8952" },
                    { 2767, "Wulveringem VEURNE", "8630" },
                    { 2768, "WUUSTWEZEL WUUSTWEZEL", "2990" },
                    { 2769, "Xhendelesse HERVE", "4652" },
                    { 2761, "WORTEGEM-PETEGEM WORTEGEM-PETEGEM", "9790" },
                    { 2770, "Xhendremael ANS", "4432" },
                    { 2772, "Yern�e-Fraineux NANDRIN", "4550" },
                    { 2773, "Yves Rocher Yves Rocher", "7512" },
                    { 2774, "Yves Rocher Yves Rocher", "7513" },
                    { 2775, "Yves-Gomez�e WALCOURT", "5650" },
                    { 2776, "YVOIR YVOIR", "5530" },
                    { 2777, "Zaffelare LOCHRISTI", "9080" },
                    { 2778, "Zandbergen GERAARDSBERGEN", "9506" },
                    { 2779, "Zande KOEKELARE", "8680" },
                    { 2771, "Xhoris FERRI�RES", "4190" },
                    { 2780, "ZANDHOVEN ZANDHOVEN", "2240" },
                    { 2760, "Wortegem WORTEGEM-PETEGEM", "9790" },
                    { 2758, "Wondelgem GENT", "9032" },
                    { 2740, "Willemeau TOURNAI", "7506" },
                    { 2741, "Willerzie GEDINNE", "5575" },
                    { 2742, "Wilrijk ANTWERPEN", "2610" },
                    { 2743, "Wilsele LEUVEN", "3012" },
                    { 2744, "Wilskerke MIDDELKERKE", "8431" },
                    { 2745, "Wimmertingen HASSELT", "3501" },
                    { 2746, "Winenne BEAURAING", "5570" },
                    { 2747, "WINGENE WINGENE", "8750" },
                    { 2759, "Wontergem DEINZE", "9800" },
                    { 2748, "Winksele HERENT", "3020" },
                    { 2750, "Witry L�GLISE", "6860" },
                    { 2751, "Wodecq ELLEZELLES", "7890" },
                    { 2752, "Woesten VLETEREN", "8640" },
                    { 2753, "Wolkrange MESSANCY", "6780" },
                    { 2754, "Wolvertem MEISE", "1861" },
                    { 2755, "WOMMELGEM WOMMELGEM", "2160" },
                    { 2756, "Wommersom LINTER", "3350" },
                    { 2757, "Wonck BASSENGE", "4690" },
                    { 2749, "Wintershoven KORTESSEM", "3722" },
                    { 2739, "WILLEBROEK WILLEBROEK", "2830" },
                    { 2781, "Zandvliet ANTWERPEN", "2040" },
                    { 2783, "Zandvoorde ZONNEBEKE", "8980" },
                    { 2806, "Zoerle-Parwijs WESTERLO", "2260" },
                    { 2807, "ZOERSEL ZOERSEL", "2980" },
                    { 2808, "Zolder HEUSDEN-ZOLDER", "3550" },
                    { 2809, "Zomergem LIEVEGEM", "9930" },
                    { 2810, "ZONHOVEN ZONHOVEN", "3520" },
                    { 2811, "ZONNEBEKE ZONNEBEKE", "8980" },
                    { 2812, "Zonnegem SINT-LIEVENS-HOUTEM", "9520" },
                    { 2813, "ZOTTEGEM ZOTTEGEM", "9620" },
                    { 2805, "Zingem KRUISEM", "9750" },
                    { 2814, "Zoutenaaie VEURNE", "8630" },
                    { 2816, "Zuidschote IEPER", "8904" },
                    { 2817, "ZUIENKERKE ZUIENKERKE", "8377" },
                    { 2818, "ZULTE ZULTE", "9870" },
                    { 2819, "Zulzeke KLUISBERGEN", "9690" },
                    { 2820, "ZUTENDAAL ZUTENDAAL", "3690" },
                    { 2821, "ZWALM ZWALM", "9630" },
                    { 2822, "ZWEVEGEM ZWEVEGEM", "8550" },
                    { 2823, "Zwevezele WINGENE", "8750" },
                    { 2815, "ZOUTLEEUW ZOUTLEEUW", "3440" },
                    { 2782, "Zandvoorde OOSTENDE", "8400" },
                    { 2804, "Zillebeke IEPER", "8902" },
                    { 2802, "Zichem SCHERPENHEUVEL-ZICHEM", "3271" },
                    { 2784, "Zarlardinge GERAARDSBERGEN", "9500" },
                    { 2785, "Zarren KORTEMARK", "8610" },
                    { 2786, "ZAVENTEM ZAVENTEM", "1930" },
                    { 2787, "ZEDELGEM ZEDELGEM", "8210" },
                    { 2788, "Zeebrugge BRUGGE", "8380" },
                    { 2789, "Zegelsem BRAKEL", "9660" },
                    { 2790, "ZELE ZELE", "9240" },
                    { 2791, "Zelem HALEN", "3545" },
                    { 2803, "Zichen-Zussen-Bolder RIEMST", "3770" },
                    { 2792, "Zellik ASSE", "1731" },
                    { 2794, "ZEMST ZEMST", "1980" },
                    { 2795, "Zepperen SINT-TRUIDEN", "3800" },
                    { 2796, "Zerkegem JABBEKE", "8490" },
                    { 2797, "Z�trud-Lumay JODOIGNE", "1370" },
                    { 2798, "Zevekote GISTEL", "8470" },
                    { 2799, "Zeveneken LOCHRISTI", "9080" },
                    { 2800, "Zeveren DEINZE", "9800" },
                    { 2801, "Zevergem DE PINTE", "9840" },
                    { 2793, "ZELZATE ZELZATE", "9060" },
                    { 2738, "Willebringen BOUTERSEM", "3370" },
                    { 2737, "Willaupuis LEUZE-EN-HAINAUT", "7904" },
                    { 2736, "Wilderen SINT-TRUIDEN", "3803" },
                    { 2673, "Waudrez BINCHE", "7131" },
                    { 2674, "Waulsort HASTI�RE", "5540" },
                    { 2675, "Wauthier-Braine BRAINE-LE-CH�TEAU", "1440" },
                    { 2676, "WAVRE WAVRE", "1300" },
                    { 2677, "Wavreille ROCHEFORT", "5580" },
                    { 2678, "Wayaux LES BONS VILLERS", "6210" },
                    { 2679, "Ways GENAPPE", "1474" },
                    { 2680, "Webbekom DIEST", "3290" },
                    { 2672, "Wattripont FRASNES-LEZ-ANVAING", "7910" },
                    { 2681, "Wechelderzande LILLE", "2275" },
                    { 2683, "Weerde ZEMST", "1982" },
                    { 2684, "Weert BORNEM", "2880" },
                    { 2685, "Wegnez PEPINSTER", "4860" },
                    { 2686, "Weillen ONHAYE", "5523" },
                    { 2687, "WEISMES WEISMES", "4950" },
                    { 2688, "Welden OUDENAARDE", "9700" },
                    { 2689, "WELKENRAEDT WELKENRAEDT", "4840" },
                    { 2690, "Welle DENDERLEEUW", "9473" },
                    { 2682, "Weelde RAVELS", "2381" },
                    { 2691, "WELLEN WELLEN", "3830" },
                    { 2671, "Watou POPERINGE", "8978" },
                    { 2669, "WATERMAAL-BOSVOORDE WATERMAAL-BOSVOORDE", "1170" },
                    { 2651, "Warcoing PECQ", "7740" },
                    { 2652, "Wardin BASTOGNE", "6600" },
                    { 2653, "WAREGEM WAREGEM", "8790" },
                    { 2654, "WAREMME WAREMME", "4300" },
                    { 2655, "Waret-L'Ev�que H�RON", "4217" },
                    { 2656, "Waret-La-Chauss�e EGHEZ�E", "5310" },
                    { 2657, "Warisoulx LA BRUY�RE", "5080" },
                    { 2658, "Warnant ANH�E", "5537" },
                    { 2670, "Watervliet SINT-LAUREINS", "9988" },
                    { 2659, "Warnant-Dreye VILLERS-LE-BOUILLET", "4530" },
                    { 2661, "Warsage DALHEM", "4608" },
                    { 2662, "Warz�e OUFFET", "4590" },
                    { 2663, "Wasmes COLFONTAINE", "7340" },
                    { 2664, "Wasmes-Audemez-Briffoeil P�RUWELZ", "7604" },
                    { 2665, "Wasmuel QUAREGNON", "7390" },
                    { 2666, "WASSEIGES WASSEIGES", "4219" },
                    { 2667, "Waterland-Oudeman SINT-LAUREINS", "9988" },
                    { 2668, "WATERLOO WATERLOO", "1410" },
                    { 2660, "Warquignies COLFONTAINE", "7340" },
                    { 2692, "WELLIN WELLIN", "6920" },
                    { 2693, "WEMMEL WEMMEL", "1780" },
                    { 2694, "Wenduine DE HAAN", "8420" },
                    { 2718, "Wezeren LANDEN", "3401" },
                    { 2719, "Wibrin HOUFFALIZE", "6666" },
                    { 2720, "WICHELEN WICHELEN", "9260" },
                    { 2721, "Widooie TONGEREN", "3700" },
                    { 2722, "Wiekevorst HEIST-OP-DEN-BERG", "2222" },
                    { 2723, "WIELSBEKE WIELSBEKE", "8710" },
                    { 2724, "Wierde NAMUR", "5100" },
                    { 2725, "Wiers P�RUWELZ", "7608" },
                    { 2717, "WEZEMBEEK-OPPEM WEZEMBEEK-OPPEM", "1970" },
                    { 2726, "Wiesme BEAURAING", "5571" },
                    { 2728, "Wih�ries DOUR", "7370" },
                    { 2729, "Wihogne JUPRELLE", "4452" },
                    { 2730, "Wijchmaal PEER", "3990" },
                    { 2731, "Wijer NIEUWERKERKEN", "3850" },
                    { 2732, "Wijgmaal LEUVEN", "3018" },
                    { 2733, "WIJNEGEM WIJNEGEM", "2110" },
                    { 2734, "Wijshagen OUDSBERGEN", "3670" },
                    { 2735, "Wijtschate HEUVELLAND", "8953" },
                    { 2727, "Wieze LEBBEKE", "9280" },
                    { 2716, "Wezemaal ROTSELAAR", "3111" },
                    { 2715, "Wez-Velvain BRUNEHAUT", "7620" },
                    { 2714, "WEVELGEM WEVELGEM", "8560" },
                    { 2695, "W�pion NAMUR", "5100" },
                    { 2696, "Werbomont FERRI�RES", "4190" },
                    { 2697, "Werchter ROTSELAAR", "3118" },
                    { 2698, "W�ris DURBUY", "6940" },
                    { 2699, "Werken KORTEMARK", "8610" },
                    { 2700, "Werm HOESELT", "3730" },
                    { 2701, "WERVIK WERVIK", "8940" },
                    { 2702, "Wespelaar HAACHT", "3150" },
                    { 2703, "Westende MIDDELKERKE", "8434" },
                    { 2704, "WESTERLO WESTERLO", "2260" },
                    { 2705, "Westkapelle KNOKKE-HEIST", "8300" },
                    { 2706, "Westkerke OUDENBURG", "8460" },
                    { 2707, "Westmalle MALLE", "2390" },
                    { 2708, "Westmeerbeek HULSHOUT", "2235" },
                    { 2709, "Westouter HEUVELLAND", "8954" },
                    { 2710, "Westrem WETTEREN", "9230" },
                    { 2711, "Westrozebeke STADEN", "8840" },
                    { 2712, "Westvleteren VLETEREN", "8640" },
                    { 2713, "WETTEREN WETTEREN", "9230" },
                    { 2474, "UKKEL UKKEL", "1180" },
                    { 2473, "Uitkerke BLANKENBERGE", "8370" },
                    { 2472, "Uitbergen BERLARE", "9290" },
                    { 2471, "Uikhoven MAASMECHELEN", "3631" },
                    { 2232, "Sint-Baafs-Vijve WIELSBEKE", "8710" },
                    { 2233, "Sint-Blasius-Boekel ZWALM", "9630" },
                    { 2234, "Sint-Denijs ZWEVEGEM", "8554" },
                    { 2235, "Sint-Denijs-Boekel ZWALM", "9630" },
                    { 2236, "Sint-Denijs-Westrem GENT", "9051" },
                    { 2237, "Sint-Eloois-Vijve WAREGEM", "8793" },
                    { 2238, "Sint-Eloois-Winkel LEDEGEM", "8880" },
                    { 2239, "SINT-GENESIUS-RODE SINT-GENESIUS-RODE", "1640" },
                    { 2231, "Sint-Antelinks HERZELE", "9550" },
                    { 2240, "SINT-GILLIS SINT-GILLIS", "1060" },
                    { 2242, "SINT-GILLIS-WAAS SINT-GILLIS-WAAS", "9170" },
                    { 2243, "Sint-Goriks-Oudenhove ZOTTEGEM", "9620" },
                    { 2244, "Sint-Huibrechts-Hern HOESELT", "3730" },
                    { 2245, "Sint-Huibrechts-Lille PELT", "3910" },
                    { 2246, "Sint-Jacobs-Kapelle DIKSMUIDE", "8600" },
                    { 2247, "Sint-Jan IEPER", "8900" },
                    { 2248, "Sint-Jan-In-Eremo SINT-LAUREINS", "9982" },
                    { 2249, "SINT-JANS-MOLENBEEK SINT-JANS-MOLENBEEK", "1080" },
                    { 2241, "Sint-Gillis-Dendermonde DENDERMONDE", "9200" },
                    { 2250, "Sint-Job-In-'T-Goor BRECHT", "2960" },
                    { 2230, "Sint-Andries BRUGGE", "8200" },
                    { 2228, "Sint-Amands PUURS-SINT-AMANDS", "2890" },
                    { 2210, "Seny TINLOT", "4557" },
                    { 2211, "Senzeilles CERFONTAINE", "5630" },
                    { 2212, "Septon DURBUY", "6940" },
                    { 2213, "SERAING SERAING", "4100" },
                    { 2214, "Seraing-Le-Ch�teau VERLAINE", "4537" },
                    { 2215, "Serinchamps CINEY", "5590" },
                    { 2216, "Serskamp WICHELEN", "9260" },
                    { 2217, "Serville ONHAYE", "5521" },
                    { 2229, "Sint-Amandsberg GENT", "9040" },
                    { 2218, "SHAPE SHAPE", "7010" },
                    { 2220, "Signeulx MUSSON", "6750" },
                    { 2221, "Sijsele DAMME", "8340" },
                    { 2222, "Silenrieux CERFONTAINE", "5630" },
                    { 2223, "SILLY SILLY", "7830" },
                    { 2224, "Sinaai-Waas SINT-NIKLAAS", "9112" },
                    { 2225, "Sinsin SOMME-LEUZE", "5377" },
                    { 2226, "SINT-AGATHA-BERCHEM SINT-AGATHA-BERCHEM", "1082" },
                    { 2227, "Sint-Agatha-Rode HULDENBERG", "3040" },
                    { 2219, "Sibret VAUX-SUR-S�RE", "6640" },
                    { 2209, "Sensenruth BOUILLON", "6832" },
                    { 2251, "SINT-JOOST-TEN-NOODE SINT-JOOST-TEN-NOODE", "1210" },
                    { 2253, "Sint-Joris BEERNEM", "8730" },
                    { 2276, "Sint-Maria-Oudenhove BRAKEL", "9660" },
                    { 2277, "Sint-Martens-Bodegem DILBEEK", "1700" },
                    { 2278, "SINT-MARTENS-LATEM SINT-MARTENS-LATEM", "9830" },
                    { 2279, "Sint-Martens-Leerne DEINZE", "9800" },
                    { 2280, "Sint-Martens-Lennik LENNIK", "1750" },
                    { 2281, "Sint-Martens-Lierde LIERDE", "9572" },
                    { 2282, "Sint-Martens-Voeren VOEREN", "3790" },
                    { 2283, "Sint-Michiels BRUGGE", "8200" },
                    { 2275, "Sint-Maria-Oudenhove ZOTTEGEM", "9620" },
                    { 2284, "SINT-NIKLAAS SINT-NIKLAAS", "9100" },
                    { 2286, "Sint-Pieters-Kapelle HERNE", "1541" },
                    { 2287, "Sint-Pieters-Kapelle MIDDELKERKE", "8433" },
                    { 2288, "SINT-PIETERS-LEEUW SINT-PIETERS-LEEUW", "1600" },
                    { 2289, "Sint-Pieters-Rode HOLSBEEK", "3220" },
                    { 2290, "Sint-Pieters-Voeren VOEREN", "3792" },
                    { 2291, "SINT-PIETERS-WOLUWE SINT-PIETERS-WOLUWE", "1150" },
                    { 2292, "Sint-Rijkers ALVERINGEM", "8690" },
                    { 2293, "Sint-Stevens-Woluwe ZAVENTEM", "1932" },
                    { 2285, "Sint-Pauwels SINT-GILLIS-WAAS", "9170" },
                    { 2252, "Sint-Joris NIEUWPOORT", "8620" },
                    { 2274, "Sint-Maria-Lierde LIERDE", "9570" },
                    { 2272, "Sint-Maria-Horebeke HOREBEKE", "9667" },
                    { 2254, "Sint-Joris-Weert OUD-HEVERLEE", "3051" },
                    { 2255, "Sint-Joris-Winge TIELT-WINGE", "3390" },
                    { 2256, "SINT-KATELIJNE-WAVER SINT-KATELIJNE-WAVER", "2860" },
                    { 2257, "Sint-Katherina-Lombeek TERNAT", "1742" },
                    { 2258, "Sint-Kornelis-Horebeke HOREBEKE", "9667" },
                    { 2259, "Sint-Kruis BRUGGE", "8310" },
                    { 2260, "Sint-Kruis-Winkel GENT", "9042" },
                    { 2261, "Sint-Kwintens-Lennik LENNIK", "1750" },
                    { 2273, "Sint-Maria-Latem ZWALM", "9630" },
                    { 2262, "Sint-Lambrechts-Herk HASSELT", "3500" },
                    { 2264, "SINT-LAUREINS SINT-LAUREINS", "9980" },
                    { 2265, "Sint-Laureins-Berchem SINT-PIETERS-LEEUW", "1600" },
                    { 2266, "Sint-Lenaarts BRECHT", "2960" },
                    { 2267, "Sint-Lievens-Esse HERZELE", "9550" },
                    { 2268, "SINT-LIEVENS-HOUTEM SINT-LIEVENS-HOUTEM", "9520" },
                    { 2269, "Sint-Margriete SINT-LAUREINS", "9981" },
                    { 2270, "Sint-Margriete-Houtem TIENEN", "3300" },
                    { 2271, "Sint-Margriete-Houtem KORTENAKEN", "3470" },
                    { 2263, "SINT-LAMBRECHTS-WOLUWE SINT-LAMBRECHTS-WOLUWE", "1200" },
                    { 2208, "SENEFFE SENEFFE", "7180" },
                    { 2207, "Semmerzake GAVERE", "9890" },
                    { 2206, "Seloignes MOMIGNIES", "6596" },
                    { 2143, "Saint-Martin JEMEPPE-SUR-SAMBRE", "5190" },
                    { 2144, "Saint-Maur TOURNAI", "7500" },
                    { 2145, "Saint-M�dard HERBEUMONT", "6887" },
                    { 2146, "SAINT-NICOLAS SAINT-NICOLAS", "4420" },
                    { 2147, "Saint-Pierre LIBRAMONT-CHEVIGNY", "6800" },
                    { 2148, "Saint-Remy BL�GNY", "4672" },
                    { 2149, "Saint-Remy CHIMAY", "6460" },
                    { 2150, "Saint-Remy-Geest JODOIGNE", "1370" },
                    { 2142, "Saint-Mard VIRTON", "6762" },
                    { 2151, "Saint-Sauveur FRASNES-LEZ-ANVAING", "7912" },
                    { 2153, "Saint-S�verin NANDRIN", "4550" },
                    { 2154, "Saint-Symphorien MONS", "7030" },
                    { 2155, "Saint-Vaast LA LOUVI�RE", "7100" },
                    { 2156, "Saint-Vincent TINTIGNY", "6730" },
                    { 2157, "Sainte-C�cile FLORENVILLE", "6820" },
                    { 2158, "Sainte-Marie-Chevigny LIBRAMONT-CHEVIGNY", "6800" },
                    { 2159, "Sainte-Marie-Sur-Semois ETALLE", "6740" },
                    { 2160, "SAINTE-ODE SAINTE-ODE", "6680" },
                    { 2152, "Saint-Servais NAMUR", "5002" },
                    { 2161, "Saintes TUBIZE", "1480" },
                    { 2141, "Saint-Marc NAMUR", "5003" },
                    { 2139, "SAINT-L�GER SAINT-L�GER", "6747" },
                    { 2121, "Runkelen SINT-TRUIDEN", "3803" },
                    { 2122, "Rupelmonde KRUIBEKE", "9150" },
                    { 2123, "Russeignies MONT-DE-L'ENCLUS", "7750" },
                    { 2124, "Rutten TONGEREN", "3700" },
                    { 2125, "S Gravenvoeren VOEREN", "3798" },
                    { 2126, "SA SudPresse SA SudPresse", "5010" },
                    { 2127, "Saint-Amand FLEURUS", "6221" },
                    { 2128, "Saint-Andr� DALHEM", "4606" },
                    { 2140, "Saint-L�ger ESTAIMPUIS", "7730" },
                    { 2129, "Saint-Aubin FLORENNES", "5620" },
                    { 2131, "Saint-Denis-Bovesse LA BRUY�RE", "5081" },
                    { 2132, "SAINT-GEORGES-SUR-MEUSE SAINT-GEORGES-SUR-MEUSE", "4470" },
                    { 2133, "Saint-G�rard METTET", "5640" },
                    { 2134, "Saint-Germain EGHEZ�E", "5310" },
                    { 2135, "Saint-G�ry CHASTRE", "1450" },
                    { 2136, "SAINT-GHISLAIN SAINT-GHISLAIN", "7330" },
                    { 2137, "SAINT-HUBERT SAINT-HUBERT", "6870" },
                    { 2138, "Saint-Jean-Geest JODOIGNE", "1370" },
                    { 2130, "Saint-Denis MONS", "7034" },
                    { 2162, "Saive BL�GNY", "4671" },
                    { 2163, "Salles CHIMAY", "6460" },
                    { 2164, "Samart PHILIPPEVILLE", "5600" },
                    { 2188, "Schellebelle WICHELEN", "9260" },
                    { 2189, "Schendelbeke GERAARDSBERGEN", "9506" },
                    { 2190, "Schepdaal DILBEEK", "1703" },
                    { 2191, "Scherpenheuvel SCHERPENHEUVEL-ZICHEM", "3270" },
                    { 2192, "SCHERPENHEUVEL-ZICHEM SCHERPENHEUVEL-ZICHEM", "3270" },
                    { 2193, "SCHILDE SCHILDE", "2970" },
                    { 2194, "Schoonaarde DENDERMONDE", "9200" },
                    { 2195, "Schore MIDDELKERKE", "8433" },
                    { 2187, "SCHELLE SCHELLE", "2627" },
                    { 2196, "Schorisse MAARKEDAL", "9688" },
                    { 2198, "Schriek HEIST-OP-DEN-BERG", "2223" },
                    { 2199, "Schuiferskapelle TIELT", "8700" },
                    { 2200, "Schulen HERK-DE-STAD", "3540" },
                    { 2201, "Sch�nberg SANKT-VITH", "4782" },
                    { 2202, "Sclayn ANDENNE", "5300" },
                    { 2203, "Scy HAMOIS", "5361" },
                    { 2204, "Seilles ANDENNE", "5300" },
                    { 2205, "S�lange MESSANCY", "6781" },
                    { 2197, "SCHOTEN SCHOTEN", "2900" },
                    { 2186, "Scheldewindeke OOSTERZELE", "9860" },
                    { 2185, "Schelderode MERELBEKE", "9820" },
                    { 2184, "Schaltin HAMOIS", "5364" },
                    { 2165, "SAMBREVILLE SAMBREVILLE", "5060" },
                    { 2166, "Samr�e LA ROCHE-EN-ARDENNE", "6982" },
                    { 2167, "SANKT-VITH SANKT-VITH", "4780" },
                    { 2168, "Sars-La-Bruy�re FRAMERIES", "7080" },
                    { 2169, "Sars-La-Buissi�re LOBBES", "6542" },
                    { 2170, "Sart-Bernard ASSESSE", "5330" },
                    { 2171, "Sart-Custinne GEDINNE", "5575" },
                    { 2172, "Sart-Dames-Avelines VILLERS-LA-VILLE", "1495" },
                    { 2173, "Sart-En-Fagne PHILIPPEVILLE", "5600" },
                    { 2174, "Sart-Eustache FOSSES-LA-VILLE", "5070" },
                    { 2175, "Sart-Lez-Spa JALHAY", "4845" },
                    { 2176, "Sart-Saint-Laurent FOSSES-LA-VILLE", "5070" },
                    { 2177, "Sautin SIVRY-RANCE", "6470" },
                    { 2178, "Sautour PHILIPPEVILLE", "5600" },
                    { 2179, "Sauveni�re GEMBLOUX", "5030" },
                    { 2180, "Scanning Scanning", "1101" },
                    { 2181, "SCHAARBEEK SCHAARBEEK", "1030" },
                    { 2182, "Schaffen DIEST", "3290" },
                    { 2183, "Schalkhoven HOESELT", "3732" },
                    { 2294, "SINT-TRUIDEN SINT-TRUIDEN", "3800" },
                    { 1414, "Lisogne DINANT", "5501" },
                    { 2295, "Sint-Ulriks-Kapelle DILBEEK", "1700" },
                    { 2297, "Sippenaeken PLOMBI�RES", "4851" },
                    { 2409, "Thommen BURG-REULAND", "4791" },
                    { 2410, "Thon ANDENNE", "5300" },
                    { 2411, "Thorembais-Les-B�guines PERWEZ", "1360" },
                    { 2412, "Thorembais-Saint-Trond PERWEZ", "1360" },
                    { 2413, "Thoricourt SILLY", "7830" },
                    { 2414, "Thuillies THUIN", "6536" },
                    { 2415, "THUIN THUIN", "6530" },
                    { 2416, "Thulin HENSIES", "7350" },
                    { 2408, "Thisnes HANNUT", "4280" },
                    { 2417, "Thumaide BELOEIL", "7971" },
                    { 2419, "Thy-Le-Ch�teau WALCOURT", "5651" },
                    { 2420, "Thynes DINANT", "5502" },
                    { 2421, "Thys CRISN�E", "4367" },
                    { 2422, "Tiegem ANZEGEM", "8573" },
                    { 2423, "Tielen KASTERLEE", "2460" },
                    { 2424, "Tielrode TEMSE", "9140" },
                    { 2425, "Tielt TIELT-WINGE", "3390" },
                    { 2426, "TIELT TIELT", "8700" },
                    { 2418, "Thy-Le-Baudouin FLORENNES", "5621" },
                    { 2427, "TIELT-WINGE TIELT-WINGE", "3390" },
                    { 2407, "Thirimont BEAUMONT", "6500" },
                    { 2405, "Thimougies TOURNAI", "7533" },
                    { 2387, "Teralfene AFFLIGEM", "1790" },
                    { 2388, "Terhagen RUMST", "2840" },
                    { 2389, "Termes CHINY", "6813" },
                    { 2390, "TERNAT TERNAT", "1740" },
                    { 2391, "Tertre SAINT-GHISLAIN", "7333" },
                    { 2392, "TERVUREN TERVUREN", "3080" },
                    { 2393, "Terwagne CLAVIER", "4560" },
                    { 2394, "TESSENDERLO TESSENDERLO", "3980" },
                    { 2406, "Thines NIVELLES", "1402" },
                    { 2395, "Testelt SCHERPENHEUVEL-ZICHEM", "3272" },
                    { 2397, "THEUX THEUX", "4910" },
                    { 2398, "Thiaumont ATTERT", "6717" },
                    { 2399, "Thieu LE ROEULX", "7070" },
                    { 2400, "Thieulain LEUZE-EN-HAINAUT", "7901" },
                    { 2401, "Thieusies SOIGNIES", "7061" },
                    { 2402, "Thim�on PONT-�-CELLES", "6230" },
                    { 2403, "Thimister THIMISTER-CLERMONT", "4890" },
                    { 2404, "THIMISTER-CLERMONT THIMISTER-CLERMONT", "4890" },
                    { 2396, "Teuven VOEREN", "3793" },
                    { 2386, "TENNEVILLE TENNEVILLE", "6970" },
                    { 2428, "TIENEN TIENEN", "3300" },
                    { 2430, "Tihange HUY", "4500" },
                    { 2453, "Tourinne BRAIVES", "4263" },
                    { 2454, "Tourinnes-La-Grosse BEAUVECHAIN", "1320" },
                    { 2455, "Tourinnes-Saint-Lambert WALHAIN", "1457" },
                    { 2456, "TOURNAI TOURNAI", "7500" },
                    { 2457, "Tournay NEUFCH�TEAU", "6840" },
                    { 2458, "Tourpes LEUZE-EN-HAINAUT", "7904" },
                    { 2459, "Transinne LIBIN", "6890" },
                    { 2460, "Trazegnies COURCELLES", "6183" },
                    { 2452, "TORHOUT TORHOUT", "8820" },
                    { 2461, "Treignes VIROINVAL", "5670" },
                    { 2463, "TREMELO TREMELO", "3120" },
                    { 2464, "Trivi�res LA LOUVI�RE", "7100" },
                    { 2465, "Trogn�e HANNUT", "4280" },
                    { 2466, "TROIS-PONTS TROIS-PONTS", "4980" },
                    { 2467, "TROOZ TROOZ", "4870" },
                    { 2468, "TUBIZE TUBIZE", "1480" },
                    { 2469, "TURNHOUT TURNHOUT", "2300" },
                    { 2470, "Ucimont BOUILLON", "6833" },
                    { 2462, "Trembleur BL�GNY", "4670" },
                    { 2429, "Tign�e SOUMAGNE", "4630" },
                    { 2451, "Torgny ROUVROY", "6767" },
                    { 2449, "Tongrinne SOMBREFFE", "5140" },
                    { 2431, "Tildonk HAACHT", "3150" },
                    { 2432, "Tilff ESNEUX", "4130" },
                    { 2433, "Tillet SAINTE-ODE", "6680" },
                    { 2434, "Tilleur SAINT-NICOLAS", "4420" },
                    { 2435, "Tillier FERNELMONT", "5380" },
                    { 2436, "Tilly VILLERS-LA-VILLE", "1495" },
                    { 2437, "TINLOT TINLOT", "4557" },
                    { 2438, "Tintange FAUVILLERS", "6637" },
                    { 2450, "Tontelange ATTERT", "6717" },
                    { 2439, "TINTIGNY TINTIGNY", "6730" },
                    { 2441, "Toernich ARLON", "6700" },
                    { 2442, "Tohogne DURBUY", "6941" },
                    { 2443, "Tollembeek GALMAARDEN", "1570" },
                    { 2444, "TONGEREN TONGEREN", "3700" },
                    { 2445, "Tongerlo WESTERLO", "2260" },
                    { 2446, "Tongerlo BREE", "3960" },
                    { 2447, "Tongre-Notre-Dame CHI�VRES", "7951" },
                    { 2448, "Tongre-Saint-Martin CHI�VRES", "7950" },
                    { 2440, "Tisselt WILLEBROEK", "2830" },
                    { 2385, "TEMSE TEMSE", "9140" },
                    { 2384, "Temploux NAMUR", "5020" },
                    { 2383, "Templeuve TOURNAI", "7520" },
                    { 2320, "Somz�e WALCOURT", "5651" },
                    { 2321, "Sor�e GESVES", "5340" },
                    { 2322, "Sorinne-La-Longue ASSESSE", "5333" },
                    { 2323, "Sorinnes DINANT", "5503" },
                    { 2324, "Sosoye ANH�E", "5537" },
                    { 2325, "Sougn�-Remouchamps AYWAILLE", "4920" },
                    { 2326, "Soulme DOISCHE", "5680" },
                    { 2327, "SOUMAGNE SOUMAGNE", "4630" },
                    { 2319, "Sommi�re ONHAYE", "5523" },
                    { 2328, "Soumoy CERFONTAINE", "5630" },
                    { 2330, "Souvret COURCELLES", "6182" },
                    { 2331, "Sovet CINEY", "5590" },
                    { 2332, "Soy EREZ�E", "6997" },
                    { 2333, "Soye FLOREFFE", "5150" },
                    { 2334, "SPA SPA", "4900" },
                    { 2335, "Spalbeek HASSELT", "3510" },
                    { 2336, "Spiennes MONS", "7032" },
                    { 2337, "Spiere SPIERE-HELKIJN", "8587" },
                    { 2329, "Sourbrodt WEISMES", "4950" },
                    { 2338, "SPIERE-HELKIJN SPIERE-HELKIJN", "8587" },
                    { 2318, "Sommethonne MEIX-DEVANT-VIRTON", "6769" },
                    { 2316, "SOMBREFFE SOMBREFFE", "5140" },
                    { 2298, "Sirault SAINT-GHISLAIN", "7332" },
                    { 2299, "Sivry SIVRY-RANCE", "6470" },
                    { 2300, "SIVRY-RANCE SIVRY-RANCE", "6470" },
                    { 2301, "Sleidinge EVERGEM", "9940" },
                    { 2302, "Slijpe MIDDELKERKE", "8433" },
                    { 2303, "Slins JUPRELLE", "4450" },
                    { 2304, "Sluizen TONGEREN", "3700" },
                    { 2305, "Smeerebbe-Vloerzegem GERAARDSBERGEN", "9506" },
                    { 2317, "SOMME-LEUZE SOMME-LEUZE", "5377" },
                    { 2306, "Smetlede LEDE", "9340" },
                    { 2308, "Snaaskerke GISTEL", "8470" },
                    { 2309, "Snellegem JABBEKE", "8490" },
                    { 2310, "Soheit-Tinlot TINLOT", "4557" },
                    { 2311, "Sohier WELLIN", "6920" },
                    { 2312, "SOIGNIES SOIGNIES", "7060" },
                    { 2313, "Soiron PEPINSTER", "4861" },
                    { 2314, "Solre-Saint-G�ry BEAUMONT", "6500" },
                    { 2315, "Solre-Sur-Sambre ERQUELINNES", "6560" },
                    { 2307, "Smuid LIBIN", "6890" },
                    { 2339, "Spontin YVOIR", "5530" },
                    { 2340, "SPRIMONT SPRIMONT", "4140" },
                    { 2341, "Spy JEMEPPE-SUR-SAMBRE", "5190" },
                    { 2365, "Str�e-Lez-Huy MODAVE", "4577" },
                    { 2366, "Str�py-Bracquegnies LA LOUVI�RE", "7110" },
                    { 2367, "Strijpen ZOTTEGEM", "9620" },
                    { 2368, "Strijtem ROOSDAAL", "1760" },
                    { 2369, "Strombeek-Bever GRIMBERGEN", "1853" },
                    { 2370, "Stuivekenskerke DIKSMUIDE", "8600" },
                    { 2371, "Suarl�e NAMUR", "5020" },
                    { 2372, "Sugny VRESSE-SUR-SEMOIS", "5550" },
                    { 2364, "Str�e BEAUMONT", "6511" },
                    { 2373, "Surice PHILIPPEVILLE", "5600" },
                    { 2375, "Tailles HOUFFALIZE", "6661" },
                    { 2376, "Taintignies RUMES", "7618" },
                    { 2377, "Tamines SAMBREVILLE", "5060" },
                    { 2378, "Tarcienne WALCOURT", "5651" },
                    { 2379, "Tavier ANTHISNES", "4163" },
                    { 2380, "Taviers EGHEZ�E", "5310" },
                    { 2381, "Tavigny HOUFFALIZE", "6662" },
                    { 2382, "TELLIN TELLIN", "6927" },
                    { 2374, "Suxy CHINY", "6812" },
                    { 2363, "Straimont HERBEUMONT", "6887" },
                    { 2362, "STOUMONT STOUMONT", "4987" },
                    { 2361, "Stokrooie HASSELT", "3511" },
                    { 2342, "STABROEK STABROEK", "2940" },
                    { 2343, "STADEN STADEN", "8840" },
                    { 2344, "Stalhille JABBEKE", "8490" },
                    { 2345, "Stambruges BELOEIL", "7973" },
                    { 2346, "Stave METTET", "5646" },
                    { 2347, "Stavele ALVERINGEM", "8691" },
                    { 2348, "STAVELOT STAVELOT", "4970" }
                });

            migrationBuilder.InsertData(
                table: "ZipCode",
                columns: new[] { "Id", "City", "Code" },
                values: new object[,]
                {
                    { 2349, "Steendorp TEMSE", "9140" },
                    { 2350, "Steenhuffel LONDERZEEL", "1840" },
                    { 2351, "Steenhuize-Wijnhuize HERZELE", "9550" },
                    { 2352, "Steenkerke VEURNE", "8630" },
                    { 2353, "Steenkerque BRAINE-LE-COMTE", "7090" },
                    { 2354, "STEENOKKERZEEL STEENOKKERZEEL", "1820" },
                    { 2355, "STEKENE STEKENE", "9190" },
                    { 2356, "Stembert VERVIERS", "4801" },
                    { 2357, "Stene OOSTENDE", "8400" },
                    { 2358, "Sterrebeek ZAVENTEM", "1933" },
                    { 2359, "Stevoort HASSELT", "3512" },
                    { 2360, "Stokkem DILSEN-STOKKEM", "3650" },
                    { 2296, "Sinterklaas Sinterklaas", "0612" },
                    { 2824, "Zwijnaarde GENT", "9052" },
                    { 1413, "Lippelo PUURS-SINT-AMANDS", "2890" },
                    { 1411, "LINT LINT", "2547" },
                    { 465, "Clermont-Sous-Huy ENGIS", "4480" },
                    { 466, "Cognel�e NAMUR", "5022" },
                    { 467, "COLFONTAINE COLFONTAINE", "7340" },
                    { 468, "COMBLAIN-AU-PONT COMBLAIN-AU-PONT", "4170" },
                    { 469, "Comblain-Fairon HAMOIR", "4180" },
                    { 470, "Comblain-La-Tour HAMOIR", "4180" },
                    { 471, "Conneux CINEY", "5590" },
                    { 472, "Corbais MONT-SAINT-GUIBERT", "1435" },
                    { 464, "Clermont WALCOURT", "5650" },
                    { 473, "Corbion BOUILLON", "6838" },
                    { 475, "Corenne FLORENNES", "5620" },
                    { 476, "Cornesse PEPINSTER", "4860" },
                    { 477, "Cornimont BI�VRE", "5555" },
                    { 478, "Corporate Village Corporate Village", "1935" },
                    { 479, "Corroy-Le-Ch�teau GEMBLOUX", "5032" },
                    { 480, "Corroy-Le-Grand CHAUMONT-GISTOUX", "1325" },
                    { 481, "Corswarem BERLOZ", "4257" },
                    { 482, "Cortil-Noirmont CHASTRE", "1450" },
                    { 474, "Cordes FRASNES-LEZ-ANVAING", "7910" },
                    { 483, "Cortil-Wodon FERNELMONT", "5380" },
                    { 463, "Clermont THIMISTER-CLERMONT", "4890" },
                    { 461, "Clabecq TUBIZE", "1480" },
                    { 443, "CHAUDFONTAINE CHAUDFONTAINE", "4050" },
                    { 444, "CHAUMONT-GISTOUX CHAUMONT-GISTOUX", "1325" },
                    { 445, "Chauss�e-Notre-Dame-Louvignies SOIGNIES", "7063" },
                    { 446, "Ch�n�e LI�GE", "4032" },
                    { 447, "Cherain GOUVY", "6673" },
                    { 448, "Cheratte VIS�", "4602" },
                    { 449, "Chercq TOURNAI", "7521" },
                    { 450, "Chevetogne CINEY", "5590" },
                    { 462, "CLAVIER CLAVIER", "4560" },
                    { 451, "Chevron STOUMONT", "4987" },
                    { 453, "CHIMAY CHIMAY", "6460" },
                    { 454, "CHINY CHINY", "6810" },
                    { 455, "Chokier FL�MALLE", "4400" },
                    { 456, "Christelijke Sociale Organisaties Christelijke Sociale Organisaties", "1031" },
                    { 457, "Ciergnon HOUYET", "5560" },
                    { 458, "CINEY CINEY", "5590" },
                    { 459, "Ciplet BRAIVES", "4260" },
                    { 460, "Ciply MONS", "7024" },
                    { 452, "CHI�VRES CHI�VRES", "7950" },
                    { 442, "Ch�tillon SAINT-L�GER", "6747" },
                    { 484, "Couillet CHARLEROI", "6010" },
                    { 486, "COURCELLES COURCELLES", "6180" },
                    { 509, "DAMME DAMME", "8340" },
                    { 510, "Dampicourt ROUVROY", "6767" },
                    { 511, "Dampremy CHARLEROI", "6020" },
                    { 512, "Darion GEER", "4253" },
                    { 513, "Daussois CERFONTAINE", "5630" },
                    { 514, "Daussoulx NAMUR", "5020" },
                    { 515, "Dave NAMUR", "5100" },
                    { 516, "DAVERDISSE DAVERDISSE", "6929" },
                    { 508, "DALHEM DALHEM", "4607" },
                    { 517, "DE HAAN DE HAAN", "8420" },
                    { 519, "De Moeren VEURNE", "8630" },
                    { 520, "DE PANNE DE PANNE", "8660" },
                    { 521, "DE PINTE DE PINTE", "9840" },
                    { 522, "DEERLIJK DEERLIJK", "8540" },
                    { 523, "Deftinge LIERDE", "9570" },
                    { 524, "DEINZE DEINZE", "9800" },
                    { 525, "Denderbelle LEBBEKE", "9280" },
                    { 526, "Denderhoutem HAALTERT", "9450" },
                    { 518, "De Klinge SINT-GILLIS-WAAS", "9170" },
                    { 485, "Cour-Sur-Heure HAM-SUR-HEURE", "6120" },
                    { 507, "Daknam LOKEREN", "9160" },
                    { 505, "Dadizele MOORSLEDE", "8890" },
                    { 487, "Courri�re ASSESSE", "5336" },
                    { 488, "COURT-SAINT-ETIENNE COURT-SAINT-ETIENNE", "1490" },
                    { 489, "Couthuin H�RON", "4218" },
                    { 490, "Coutisse ANDENNE", "5300" },
                    { 491, "Couture-Saint-Germain LASNE", "1380" },
                    { 492, "COUVIN COUVIN", "5660" },
                    { 493, "Cras-Avernas HANNUT", "4280" },
                    { 494, "Crehen HANNUT", "4280" },
                    { 506, "Dailly COUVIN", "5660" },
                    { 495, "CRISN�E CRISN�E", "4367" },
                    { 497, "Crombach SANKT-VITH", "4784" },
                    { 498, "Crupet ASSESSE", "5332" },
                    { 499, "CSM Charleroi X CSM Charleroi X", "6075" },
                    { 500, "CSM Gent X CSM Gent X", "9075" },
                    { 501, "Cuesmes MONS", "7033" },
                    { 502, "Cugnon BERTRIX", "6880" },
                    { 503, "Cul-Des-Sarts COUVIN", "5660" },
                    { 504, "Custinne HOUYET", "5562" },
                    { 496, "Croix-Lez-Rouveroy ESTINNES", "7120" },
                    { 527, "DENDERLEEUW DENDERLEEUW", "9470" },
                    { 441, "Ch�telineau CH�TELET", "6200" },
                    { 439, "Chastr�s WALCOURT", "5650" },
                    { 377, "BRUGELETTE BRUGELETTE", "7940" },
                    { 378, "BRUGGE BRUGGE", "8000" },
                    { 379, "Br�ly COUVIN", "5660" },
                    { 380, "Br�ly-De-Pesche COUVIN", "5660" },
                    { 381, "BRUNEHAUT BRUNEHAUT", "7620" },
                    { 382, "Brussegem MERCHTEM", "1785" },
                    { 383, "BRUSSEL BRUSSEL", "1000" },
                    { 384, "Brussel X Brussel X", "1099" },
                    { 376, "Brucargo Brucargo", "1931" },
                    { 385, "Brustem SINT-TRUIDEN", "3800" },
                    { 387, "Brye FLEURUS", "6222" },
                    { 388, "Budingen ZOUTLEEUW", "3440" },
                    { 389, "BUGGENHOUT BUGGENHOUT", "9255" },
                    { 390, "Buissenal FRASNES-LEZ-ANVAING", "7911" },
                    { 391, "Buissonville ROCHEFORT", "5580" },
                    { 392, "Buizingen HALLE", "1501" },
                    { 393, "Buken KAMPENHOUT", "1910" },
                    { 394, "Bulskamp VEURNE", "8630" },
                    { 386, "Bruyelle ANTOING", "7641" },
                    { 395, "Bunsbeek GLABBEEK", "3380" },
                    { 375, "Broekom BORGLOON", "3840" },
                    { 373, "Brielen IEPER", "8900" },
                    { 355, "Bra LIERNEUX", "4990" },
                    { 356, "Braffe P�RUWELZ", "7604" },
                    { 357, "Braibant CINEY", "5590" },
                    { 358, "BRAINE-L'ALLEUD BRAINE-L'ALLEUD", "1420" },
                    { 359, "BRAINE-LE-CH�TEAU BRAINE-LE-CH�TEAU", "1440" },
                    { 360, "BRAINE-LE-COMTE BRAINE-LE-COMTE", "7090" },
                    { 361, "BRAIVES BRAIVES", "4260" },
                    { 362, "BRAKEL BRAKEL", "9660" },
                    { 374, "Broechem RANST", "2520" },
                    { 363, "Branchon EGHEZ�E", "5310" },
                    { 365, "Brasm�nil P�RUWELZ", "7604" },
                    { 366, "BRASSCHAAT BRASSCHAAT", "2930" },
                    { 367, "Bray BINCHE", "7130" },
                    { 368, "BRECHT BRECHT", "2960" },
                    { 369, "BREDENE BREDENE", "8450" },
                    { 370, "BREE BREE", "3960" },
                    { 371, "Breendonk PUURS-SINT-AMANDS", "2870" },
                    { 372, "Bressoux LI�GE", "4020" },
                    { 364, "Bras LIBRAMONT-CHEVIGNY", "6800" },
                    { 440, "CH�TELET CH�TELET", "6200" },
                    { 396, "Burcht ZWIJNDRECHT", "2070" },
                    { 398, "Bure TELLIN", "6927" },
                    { 421, "CERFONTAINE CERFONTAINE", "5630" },
                    { 422, "C�roux-Mousty OTTIGNIES-LOUVAIN-LA-NEUVE", "1341" },
                    { 423, "Chaineux HERVE", "4650" },
                    { 424, "Chairi�re VRESSE-SUR-SEMOIS", "5550" },
                    { 425, "Champion NAMUR", "5020" },
                    { 426, "Champlon TENNEVILLE", "6971" },
                    { 427, "Chanly WELLIN", "6921" },
                    { 428, "Chantemelle ETALLE", "6742" },
                    { 420, "C�rexhe-Heuseux SOUMAGNE", "4632" },
                    { 429, "Chapelle-�-Oie LEUZE-EN-HAINAUT", "7903" },
                    { 431, "CHAPELLE-LEZ-HERLAIMONT CHAPELLE-LEZ-HERLAIMONT", "7160" },
                    { 432, "Chapon-Seraing VERLAINE", "4537" },
                    { 433, "CHARLEROI CHARLEROI", "6000" },
                    { 434, "Charleroi X Charleroi X", "6099" },
                    { 435, "Charneux HERVE", "4654" },
                    { 436, "Chassepierre FLORENVILLE", "6824" },
                    { 437, "CHASTRE CHASTRE", "1450" },
                    { 438, "Chastre-Villeroux-Blanmont CHASTRE", "1450" },
                    { 430, "Chapelle-�-Wattines LEUZE-EN-HAINAUT", "7903" },
                    { 397, "BURDINNE BURDINNE", "4210" },
                    { 419, "CELLES CELLES", "7760" },
                    { 417, "Celles FAIMES", "4317" },
                    { 399, "BURG-REULAND BURG-REULAND", "4790" },
                    { 400, "Burst ERPE-MERE", "9420" },
                    { 401, "Bury P�RUWELZ", "7602" },
                    { 402, "BUTGENBACH BUTGENBACH", "4750" },
                    { 403, "Buvingen GINGELOM", "3891" },
                    { 404, "Buvrinnes BINCHE", "7133" },
                    { 405, "Buzenol ETALLE", "6743" },
                    { 406, "Buzet PONT-�-CELLES", "6230" },
                    { 418, "Celles HOUYET", "5561" },
                    { 407, "B�LLINGEN B�LLINGEN", "4760" },
                    { 409, "Calonne ANTOING", "7642" },
                    { 410, "Cambron-Casteau BRUGELETTE", "7940" },
                    { 411, "Cambron-Saint-Vincent LENS", "7870" },
                    { 412, "Cargovil Cargovil", "1804" },
                    { 413, "Carlsbourg PALISEUL", "6850" },
                    { 414, "Carni�res MORLANWELZ", "7141" },
                    { 415, "Casteau SOIGNIES", "7061" },
                    { 416, "Castillon WALCOURT", "5650" },
                    { 408, "Callenelle P�RUWELZ", "7604" },
                    { 528, "DENDERMONDE DENDERMONDE", "9200" },
                    { 529, "Denderwindeke NINOVE", "9400" },
                    { 530, "Den�e ANH�E", "5537" },
                    { 642, "Ermeton-Sur-Biert METTET", "5644" },
                    { 643, "Ernage GEMBLOUX", "5030" },
                    { 644, "Erneuville TENNEVILLE", "6972" },
                    { 645, "Ernonheid AYWAILLE", "4920" },
                    { 646, "Erondegem ERPE-MERE", "9420" },
                    { 647, "Erpe ERPE-MERE", "9420" },
                    { 648, "ERPE-MERE ERPE-MERE", "9420" },
                    { 649, "Erpent NAMUR", "5101" },
                    { 641, "EREZ�E EREZ�E", "6997" },
                    { 650, "Erpion FROIDCHAPELLE", "6441" },
                    { 652, "ERQUELINNES ERQUELINNES", "6560" },
                    { 653, "Erquennes HONNELLES", "7387" },
                    { 654, "Ertvelde EVERGEM", "9940" },
                    { 655, "Erwetegem ZOTTEGEM", "9620" },
                    { 656, "Escanaffles CELLES", "7760" },
                    { 657, "Esen DIKSMUIDE", "8600" },
                    { 658, "ESNEUX ESNEUX", "4130" },
                    { 659, "Esplechin TOURNAI", "7502" },
                    { 651, "Erps-Kwerps KORTENBERG", "3071" },
                    { 660, "Esquelmes PECQ", "7743" },
                    { 640, "Erembodegem AALST", "9320" },
                    { 638, "Erbisoeul JURBISE", "7050" },
                    { 620, "ELSENE ELSENE", "1050" },
                    { 621, "Elst BRAKEL", "9660" },
                    { 622, "Elverdinge IEPER", "8906" },
                    { 623, "Elversele TEMSE", "9140" },
                    { 624, "Emblem RANST", "2520" },
                    { 625, "Embourg CHAUDFONTAINE", "4053" },
                    { 626, "Emelgem IZEGEM", "8870" },
                    { 627, "Emines LA BRUY�RE", "5080" },
                    { 639, "Ere TOURNAI", "7500" },
                    { 628, "Emptinne HAMOIS", "5363" },
                    { 630, "Engelmanshoven SINT-TRUIDEN", "3800" },
                    { 631, "ENGIS ENGIS", "4480" },
                    { 632, "Enines ORP-JAUCHE", "1350" },
                    { 633, "Ensival VERVIERS", "4800" },
                    { 634, "Epinois BINCHE", "7134" },
                    { 635, "Eppegem ZEMST", "1980" },
                    { 636, "Eprave ROCHEFORT", "5580" },
                    { 637, "Erbaut JURBISE", "7050" },
                    { 629, "Ename OUDENAARDE", "9700" },
                    { 619, "Elsenborn BUTGENBACH", "4750" },
                    { 661, "ESSEN ESSEN", "2910" },
                    { 663, "Estaimbourg ESTAIMPUIS", "7730" },
                    { 686, "Evrehailles YVOIR", "5530" },
                    { 687, "Eynatten RAEREN", "4731" },
                    { 688, "Ezemaal LANDEN", "3400" },
                    { 689, "Fagnolle PHILIPPEVILLE", "5600" },
                    { 690, "FAIMES FAIMES", "4317" },
                    { 691, "Fala�n ONHAYE", "5522" },
                    { 692, "Falisolle SAMBREVILLE", "5060" },
                    { 693, "Fallais BRAIVES", "4260" },
                    { 685, "Evregnies ESTAIMPUIS", "7730" },
                    { 694, "Falmagne DINANT", "5500" },
                    { 696, "Familleureux SENEFFE", "7181" },
                    { 697, "FARCIENNES FARCIENNES", "6240" },
                    { 698, "Faulx-Les-Tombes GESVES", "5340" },
                    { 699, "Fauroeulx ESTINNES", "7120" },
                    { 700, "FAUVILLERS FAUVILLERS", "6637" },
                    { 701, "Faymonville WEISMES", "4950" },
                    { 702, "Fays-Les-Veneurs PALISEUL", "6856" },
                    { 703, "Fayt-Le-Franc HONNELLES", "7387" },
                    { 695, "Falmignoul DINANT", "5500" },
                    { 662, "Essene AFFLIGEM", "1790" },
                    { 684, "EVERGEM EVERGEM", "9940" },
                    { 682, "Everberg KORTENBERG", "3078" },
                    { 664, "ESTAIMPUIS ESTAIMPUIS", "7730" },
                    { 665, "ESTINNES ESTINNES", "7120" },
                    { 666, "Estinnes-Au-Mont ESTINNES", "7120" },
                    { 667, "Estinnes-Au-Val ESTINNES", "7120" },
                    { 668, "ETALLE ETALLE", "6740" },
                    { 669, "Ethe VIRTON", "6760" },
                    { 670, "Etikhove MAARKEDAL", "9680" },
                    { 671, "Ettelgem OUDENBURG", "8460" },
                    { 683, "EVERE EVERE", "1140" },
                    { 672, "ETTERBEEK ETTERBEEK", "1040" },
                    { 674, "EUPEN EUPEN", "4700" },
                    { 675, "European External Action Service European External Action Service", "1046" },
                    { 676, "Europees Parlement Europees Parlement", "1047" },
                    { 677, "Europese unie - Commissie Europese unie - Commissie", "1049" },
                    { 678, "Europese unie - Raad Europese unie - Raad", "1048" },
                    { 679, "Evegn�e SOUMAGNE", "4631" },
                    { 680, "Evelette OHEY", "5350" },
                    { 681, "Everbeek BRAKEL", "9660" },
                    { 673, "Eugies FRAMERIES", "7080" },
                    { 618, "Elsegem WORTEGEM-PETEGEM", "9790" },
                    { 617, "Elouges DOUR", "7370" },
                    { 616, "Ellikom OUDSBERGEN", "3670" },
                    { 553, "DINANT DINANT", "5500" },
                    { 554, "Dion BEAURAING", "5570" },
                    { 555, "Dion-Valmont CHAUMONT-GISTOUX", "1325" },
                    { 556, "DISON DISON", "4820" },
                    { 557, "Dochamps MANHAY", "6960" },
                    { 558, "Doel BEVEREN-WAAS", "9130" },
                    { 559, "Dohan BOUILLON", "6836" },
                    { 560, "DOISCHE DOISCHE", "5680" },
                    { 552, "DILSEN-STOKKEM DILSEN-STOKKEM", "3650" },
                    { 561, "Dolembreux SPRIMONT", "4140" },
                    { 563, "Dongelberg JODOIGNE", "1370" },
                    { 564, "Donk HERK-DE-STAD", "3540" },
                    { 565, "Donstiennes THUIN", "6536" },
                    { 566, "Dorinne YVOIR", "5530" },
                    { 567, "Dormaal ZOUTLEEUW", "3440" },
                    { 568, "Dottenijs MOESKROEN", "7711" },
                    { 569, "DOUR DOUR", "7370" },
                    { 570, "Dourbes VIROINVAL", "5670" },
                    { 562, "DONCEEL DONCEEL", "4357" },
                    { 571, "Dranouter HEUVELLAND", "8951" },
                    { 551, "Dilsen DILSEN-STOKKEM", "3650" },
                    { 549, "DIKSMUIDE DIKSMUIDE", "8600" },
                    { 531, "DENTERGEM DENTERGEM", "8720" },
                    { 532, "Dergneau FRASNES-LEZ-ANVAING", "7912" },
                    { 533, "DESSEL DESSEL", "2480" },
                    { 534, "Desselgem WAREGEM", "8792" },
                    { 535, "DESTELBERGEN DESTELBERGEN", "9070" },
                    { 536, "Desteldonk GENT", "9042" },
                    { 537, "Deurle SINT-MARTENS-LATEM", "9831" },
                    { 538, "Deurne ANTWERPEN", "2100" },
                    { 550, "DILBEEK DILBEEK", "1700" },
                    { 539, "Deurne DIEST", "3290" },
                    { 541, "Dhuy EGHEZ�E", "5310" },
                    { 542, "Diegem MACHELEN", "1831" },
                    { 543, "DIEPENBEEK DIEPENBEEK", "3590" },
                    { 544, "DIEST DIEST", "3290" },
                    { 545, "Diets-Heur TONGEREN", "3700" },
                    { 546, "Dikkebus IEPER", "8900" },
                    { 547, "Dikkele ZWALM", "9630" },
                    { 548, "Dikkelvenne GAVERE", "9890" },
                    { 540, "Deux-Acren LESSINES", "7864" },
                    { 572, "Dr�hance DINANT", "5500" },
                    { 573, "Driekapellen DIKSMUIDE", "8600" },
                    { 574, "Drieslinter LINTER", "3350" },
                    { 598, "Ehein ENGIS", "4480" },
                    { 599, "Eigenbilzen BILZEN", "3740" },
                    { 600, "Eindhout LAAKDAL", "2430" },
                    { 601, "Eine OUDENAARDE", "9700" },
                    { 602, "Eisden MAASMECHELEN", "3630" },
                    { 603, "Eke NAZARETH", "9810" },
                    { 604, "Ekeren ANTWERPEN", "2180" },
                    { 605, "Eksaarde LOKEREN", "9160" },
                    { 597, "Ehein NEUPR�", "4120" },
                    { 606, "Eksel HECHTEL-EKSEL", "3941" },
                    { 608, "Elene ZOTTEGEM", "9620" },
                    { 609, "Elewijt ZEMST", "1982" },
                    { 610, "Eliksem LANDEN", "3400" },
                    { 611, "Elingen PEPINGEN", "1671" },
                    { 612, "Ellemelle OUFFET", "4590" },
                    { 613, "ELLEZELLES ELLEZELLES", "7890" },
                    { 614, "Ellignies-Lez-Frasnes FRASNES-LEZ-ANVAING", "7910" },
                    { 615, "Ellignies-Sainte-Anne BELOEIL", "7972" },
                    { 607, "Elen DILSEN-STOKKEM", "3650" },
                    { 596, "EGHEZ�E EGHEZ�E", "5310" },
                    { 595, "Eggewaartskapelle VEURNE", "8630" },
                    { 594, "Egem PITTEM", "8740" },
                    { 575, "DROGENBOS DROGENBOS", "1620" },
                    { 576, "Drongen GENT", "9031" },
                    { 577, "Dudzele BRUGGE", "8380" },
                    { 578, "DUFFEL DUFFEL", "2570" },
                    { 579, "Duisburg TERVUREN", "3080" },
                    { 580, "Duras SINT-TRUIDEN", "3803" },
                    { 581, "DURBUY DURBUY", "6940" },
                    { 582, "Durnal YVOIR", "5530" },
                    { 583, "Dworp BEERSEL", "1653" },
                    { 584, "Eben-Emael BASSENGE", "4690" },
                    { 585, "Ebly L�GLISE", "6860" },
                    { 586, "ECAUSSINNES ECAUSSINNES", "7190" },
                    { 587, "Ecaussinnes-D'Enghien ECAUSSINNES", "7190" },
                    { 588, "Ecaussinnes-Lalaing ECAUSSINNES", "7191" },
                    { 589, "EDEGEM EDEGEM", "2650" },
                    { 590, "Edelare OUDENAARDE", "9700" },
                    { 591, "EDINGEN EDINGEN", "7850" },
                    { 592, "EEKLO EEKLO", "9900" },
                    { 593, "Eernegem ICHTEGEM", "8480" },
                    { 354, "Bovigny GOUVY", "6671" },
                    { 704, "Fayt-Lez-Manage MANAGE", "7170" },
                    { 353, "Bovesse LA BRUY�RE", "5081" },
                    { 351, "Bovelingen HEERS", "3870" },
                    { 112, "Aulnois QU�VY", "7040" },
                    { 113, "Autelbas ARLON", "6706" },
                    { 114, "Autre-Eglise RAMILLIES", "1367" },
                    { 115, "Autreppe HONNELLES", "7387" },
                    { 116, "Auvelais SAMBREVILLE", "5060" },
                    { 117, "Ave-Et-Auffe ROCHEFORT", "5580" },
                    { 118, "Avekapelle VEURNE", "8630" },
                    { 119, "AVELGEM AVELGEM", "8580" },
                    { 111, "Audregnies QUI�VRAIN", "7382" },
                    { 120, "Avennes BRAIVES", "4260" },
                    { 122, "Avernas-Le-Bauduin HANNUT", "4280" },
                    { 123, "Avin HANNUT", "4280" },
                    { 124, "AWANS AWANS", "4340" },
                    { 125, "Awenne SAINT-HUBERT", "6870" },
                    { 126, "Awirs FL�MALLE", "4400" },
                    { 127, "Aye MARCHE-EN-FAMENNE", "6900" },
                    { 128, "Ayeneux SOUMAGNE", "4630" },
                    { 129, "AYWAILLE AYWAILLE", "4920" },
                    { 121, "Averbode SCHERPENHEUVEL-ZICHEM", "3271" },
                    { 130, "Baaigem GAVERE", "9890" },
                    { 110, "Auby-Sur-Semois BERTRIX", "6880" },
                    { 108, "AUBEL AUBEL", "4880" },
                    { 90, "Asquillies QU�VY", "7040" },
                    { 91, "ASSE ASSE", "1730" },
                    { 92, "Assebroek BRUGGE", "8310" },
                    { 93, "Assembl�e de la Commission Communautaire Fran�aise Assembl�e de la Commission Communautaire Fran�aise", "1007" },
                    { 94, "ASSENEDE ASSENEDE", "9960" },
                    { 95, "Assenois L�GLISE", "6860" },
                    { 96, "Assent BEKKEVOORT", "3460" },
                    { 97, "ASSESSE ASSESSE", "5330" },
                    { 109, "Aublain COUVIN", "5660" },
                    { 98, "Astene DEINZE", "9800" },
                    { 100, "Athis HONNELLES", "7387" },
                    { 101, "Athus AUBANGE", "6791" },
                    { 102, "Attenhoven LANDEN", "3404" },
                    { 103, "Attenrode GLABBEEK", "3384" },
                    { 104, "ATTERT ATTERT", "6717" },
                    { 105, "Attre BRUGELETTE", "7941" },
                    { 106, "AUBANGE AUBANGE", "6790" },
                    { 107, "Aubechies BELOEIL", "7972" },
                    { 99, "ATH ATH", "7800" },
                    { 89, "Asper GAVERE", "9890" },
                    { 131, "Baal TREMELO", "3128" },
                    { 133, "BAARLE-HERTOG BAARLE-HERTOG", "2387" },
                    { 156, "Bas-Oha WANZE", "4520" },
                    { 157, "Bas�cles BELOEIL", "7971" },
                    { 158, "Basse-Bodeux TROIS-PONTS", "4983" },
                    { 159, "BASSENGE BASSENGE", "4690" },
                    { 160, "Bassevelde ASSENEDE", "9968" },
                    { 161, "Bassilly SILLY", "7830" },
                    { 162, "BASTOGNE BASTOGNE", "6600" },
                    { 163, "Batsheers HEERS", "3870" },
                    { 155, "Barvaux-Sur-Ourthe DURBUY", "6940" },
                    { 164, "Battice HERVE", "4651" },
                    { 166, "Baudour SAINT-GHISLAIN", "7331" },
                    { 167, "Bauffe LENS", "7870" },
                    { 168, "Baugnies P�RUWELZ", "7604" },
                    { 169, "Baulers NIVELLES", "1401" },
                    { 170, "Bavegem SINT-LIEVENS-HOUTEM", "9520" },
                    { 171, "Bavikhove HARELBEKE", "8531" },
                    { 172, "Bazel KRUIBEKE", "9150" },
                    { 173, "Beaufays CHAUDFONTAINE", "4052" },
                    { 165, "Battignies BINCHE", "7130" },
                    { 132, "Baardegem AALST", "9310" },
                    { 154, "Barvaux-Condroz HAVELANGE", "5370" },
                    { 152, "Baronville BEAURAING", "5570" },
                    { 134, "Baasrode DENDERMONDE", "9200" },
                    { 135, "Bachte-Maria-Leerne DEINZE", "9800" },
                    { 136, "BAELEN BAELEN", "4837" },
                    { 137, "Bagimont VRESSE-SUR-SEMOIS", "5550" },
                    { 138, "Baileux CHIMAY", "6464" },
                    { 139, "Baili�vre CHIMAY", "6460" },
                    { 140, "Baillamont BI�VRE", "5555" },
                    { 141, "Bailleul ESTAIMPUIS", "7730" },
                    { 153, "Barry TOURNAI", "7534" },
                    { 142, "Baillonville SOMME-LEUZE", "5377" },
                    { 144, "Baisy-Thy GENAPPE", "1470" },
                    { 145, "Bal�tre JEMEPPE-SUR-SAMBRE", "5190" },
                    { 146, "Balegem OOSTERZELE", "9860" },
                    { 147, "BALEN BALEN", "2490" },
                    { 148, "Bambrugge ERPE-MERE", "9420" },
                    { 149, "Bande NASSOGNE", "6951" },
                    { 150, "Barben�on BEAUMONT", "6500" },
                    { 151, "Barchon BL�GNY", "4671" },
                    { 143, "Baisieux QUI�VRAIN", "7380" },
                    { 174, "BEAUMONT BEAUMONT", "6500" },
                    { 88, "Aspelare NINOVE", "9404" },
                    { 86, "Arville SAINT-HUBERT", "6870" },
                    { 24, "Afsnee GENT", "9051" },
                    { 25, "Agimont HASTI�RE", "5544" },
                    { 26, "Aineffe FAIMES", "4317" },
                    { 27, "Aische-En-Refail EGHEZ�E", "5310" },
                    { 28, "Aiseau AISEAU-PRESLES", "6250" },
                    { 29, "AISEAU-PRESLES AISEAU-PRESLES", "6250" },
                    { 30, "Aisemont FOSSES-LA-VILLE", "5070" },
                    { 31, "ALKEN ALKEN", "3570" },
                    { 23, "AFFLIGEM AFFLIGEM", "1790" },
                    { 32, "Alle VRESSE-SUR-SEMOIS", "5550" },
                    { 34, "Alsemberg BEERSEL", "1652" },
                    { 35, "ALVERINGEM ALVERINGEM", "8690" },
                    { 36, "AMAY AMAY", "4540" },
                    { 37, "Amberloup SAINTE-ODE", "6680" },
                    { 38, "Ambly NASSOGNE", "6953" },
                    { 39, "Ambresin WASSEIGES", "4219" },
                    { 40, "AMEL AMEL", "4770" },
                    { 41, "Amonines EREZ�E", "6997" },
                    { 33, "Alleur ANS", "4432" },
                    { 42, "Amougies MONT-DE-L'ENCLUS", "7750" },
                    { 22, "Adinkerke DE PANNE", "8660" },
                    { 20, "ACTISOC ACTISOC", "1105" },
                    { 2, "'S Herenelderen TONGEREN", "3700" },
                    { 3, "3 Suisses 3 Suisses", "7510" },
                    { 4, "Aaigem ERPE-MERE", "9420" },
                    { 5, "Aalbeke KORTRIJK", "8511" },
                    { 6, "Aalst SINT-TRUIDEN", "3800" },
                    { 7, "AALST AALST", "9300" },
                    { 8, "AALTER AALTER", "9880" },
                    { 9, "AARSCHOT AARSCHOT", "3200" },
                    { 21, "Adegem MALDEGEM", "9991" },
                    { 10, "Aarsele TIELT", "8700" },
                    { 12, "AARTSELAAR AARTSELAAR", "2630" },
                    { 13, "Ab�e TINLOT", "4557" },
                    { 14, "Abolens HANNUT", "4280" },
                    { 15, "Achel HAMONT-ACHEL", "3930" },
                    { 16, "Ach�ne CINEY", "5590" },
                    { 17, "Achet HAMOIS", "5362" },
                    { 18, "Acosse WASSEIGES", "4219" },
                    { 19, "Acoz GERPINNES", "6280" },
                    { 11, "Aartrijke ZEDELGEM", "8211" },
                    { 87, "AS AS", "3665" },
                    { 43, "Ampsin AMAY", "4540" },
                    { 45, "ANDERLECHT ANDERLECHT", "1070" },
                    { 68, "ANTWERPEN ANTWERPEN", "2060" },
                    { 69, "Antwerpen X Antwerpen X", "2099" },
                    { 70, "Anvaing FRASNES-LEZ-ANVAING", "7910" },
                    { 71, "ANZEGEM ANZEGEM", "8570" },
                    { 72, "Appels DENDERMONDE", "9200" },
                    { 73, "Appelterre-Eichem NINOVE", "9400" },
                    { 74, "Arbre PROFONDEVILLE", "5170" },
                    { 75, "Arbre ATH", "7811" },
                    { 67, "ANTWERPEN ANTWERPEN", "2050" },
                    { 76, "Arbrefontaine LIERNEUX", "4990" },
                    { 78, "Arc-Wattripont FRASNES-LEZ-ANVAING", "7910" },
                    { 79, "Archennes GREZ-DOICEAU", "1390" },
                    { 80, "ARDOOIE ARDOOIE", "8850" },
                    { 81, "ARENDONK ARENDONK", "2370" },
                    { 82, "Argenteau VIS�", "4601" },
                    { 83, "ARLON ARLON", "6700" },
                    { 84, "Arquennes SENEFFE", "7181" },
                    { 85, "Arsimont SAMBREVILLE", "5060" },
                    { 77, "Arc-Aini�res FRASNES-LEZ-ANVAING", "7910" },
                    { 44, "ANDENNE ANDENNE", "5300" },
                    { 66, "ANTWERPEN ANTWERPEN", "2040" },
                    { 64, "ANTWERPEN ANTWERPEN", "2020" },
                    { 46, "ANDERLUES ANDERLUES", "6150" },
                    { 47, "Andrimont DISON", "4821" },
                    { 48, "Angleur LI�GE", "4031" },
                    { 49, "Angre HONNELLES", "7387" },
                    { 50, "Angreau HONNELLES", "7387" },
                    { 51, "ANH�E ANH�E", "5537" },
                    { 52, "Anlier HABAY", "6721" },
                    { 53, "Anloy LIBIN", "6890" },
                    { 65, "ANTWERPEN ANTWERPEN", "2030" },
                    { 54, "Annevoie-Rouillon ANH�E", "5537" },
                    { 56, "Anseremme DINANT", "5500" },
                    { 57, "Anseroeul MONT-DE-L'ENCLUS", "7750" },
                    { 58, "Anth�e ONHAYE", "5520" },
                    { 59, "Antheit WANZE", "4520" },
                    { 60, "ANTHISNES ANTHISNES", "4160" },
                    { 61, "ANTOING ANTOING", "7640" },
                    { 62, "ANTWERPEN ANTWERPEN", "2000" },
                    { 63, "ANTWERPEN ANTWERPEN", "2018" },
                    { 55, "ANS ANS", "4430" },
                    { 175, "BEAURAING BEAURAING", "5570" },
                    { 176, "Beausaint LA ROCHE-EN-ARDENNE", "6980" },
                    { 177, "BEAUVECHAIN BEAUVECHAIN", "1320" },
                    { 289, "Boezinge IEPER", "8904" },
                    { 290, "Bogaarden PEPINGEN", "1670" },
                    { 291, "Bohan VRESSE-SUR-SEMOIS", "5550" },
                    { 292, "Boign�e SOMBREFFE", "5140" },
                    { 293, "Boirs BASSENGE", "4690" },
                    { 294, "Bois-D'Haine MANAGE", "7170" },
                    { 295, "Bois-De-Lessines LESSINES", "7866" },
                    { 296, "Bois-De-Villers PROFONDEVILLE", "5170" },
                    { 288, "Bo�lhe GEER", "4250" },
                    { 297, "Bois-Et-Borsu CLAVIER", "4560" },
                    { 299, "Bolland HERVE", "4653" },
                    { 300, "Bomal RAMILLIES", "1367" },
                    { 301, "Bomal-Sur-Ourthe DURBUY", "6941" },
                    { 302, "Bombaye DALHEM", "4607" },
                    { 303, "Bommershoven BORGLOON", "3840" },
                    { 304, "Bon-Secours P�RUWELZ", "7603" },
                    { 305, "Boncelles SERAING", "4100" },
                    { 306, "Boneffe EGHEZ�E", "5310" },
                    { 298, "Bolinne EGHEZ�E", "5310" },
                    { 307, "BONHEIDEN BONHEIDEN", "2820" },
                    { 287, "Boekhoute ASSENEDE", "9961" },
                    { 285, "BOECHOUT BOECHOUT", "2530" },
                    { 267, "Bissegem KORTRIJK", "8501" },
                    { 268, "Bizet KOMEN-WAASTEN", "7783" },
                    { 269, "Blaasveld WILLEBROEK", "2830" },
                    { 270, "Blaimont HASTI�RE", "5542" },
                    { 271, "Blandain TOURNAI", "7522" },
                    { 272, "Blanden OUD-HEVERLEE", "3052" },
                    { 273, "BLANKENBERGE BLANKENBERGE", "8370" },
                    { 274, "Blaregnies QU�VY", "7040" },
                    { 286, "Boekhout GINGELOM", "3890" },
                    { 275, "Blaton BERNISSART", "7321" },
                    { 277, "BL�GNY BL�GNY", "4670" },
                    { 278, "Bl�haries BRUNEHAUT", "7620" },
                    { 279, "Blehen HANNUT", "4280" },
                    { 280, "Bleid VIRTON", "6760" },
                    { 281, "Bleret WAREMME", "4300" },
                    { 282, "Blicquy LEUZE-EN-HAINAUT", "7903" },
                    { 283, "BOCHOLT BOCHOLT", "3950" },
                    { 284, "Bodegn�e VERLAINE", "4537" },
                    { 276, "Blaugies DOUR", "7370" },
                    { 266, "Bioul ANH�E", "5537" },
                    { 308, "Boninne NAMUR", "5021" },
                    { 310, "Bonnert ARLON", "6700" },
                    { 333, "Bottelare MERELBEKE", "9820" },
                    { 334, "Bouffioulx CH�TELET", "6200" },
                    { 335, "Bouge NAMUR", "5004" },
                    { 336, "Bougnies QU�VY", "7040" },
                    { 337, "BOUILLON BOUILLON", "6830" },
                    { 338, "Bourlers CHIMAY", "6464" },
                    { 339, "Bourseigne-Neuve GEDINNE", "5575" },
                    { 340, "Bourseigne-Vieille GEDINNE", "5575" },
                    { 332, "Bothey GEMBLOUX", "5032" },
                    { 341, "Boussoit LA LOUVI�RE", "7110" },
                    { 343, "Boussu-En-Fagne COUVIN", "5660" },
                    { 344, "Boussu-Lez-Walcourt FROIDCHAPELLE", "6440" },
                    { 345, "Bousval GENAPPE", "1470" },
                    { 346, "BOUTERSEM BOUTERSEM", "3370" },
                    { 347, "Bouvignes-Sur-Meuse DINANT", "5500" },
                    { 348, "Bouvignies ATH", "7803" },
                    { 349, "Bouwel GROBBENDONK", "2288" },
                    { 350, "Bovekerke KOEKELARE", "8680" },
                    { 342, "BOUSSU BOUSSU", "7300" },
                    { 309, "Bonlez CHAUMONT-GISTOUX", "1325" },
                    { 331, "Bost TIENEN", "3300" },
                    { 329, "Bossuit AVELGEM", "8583" },
                    { 311, "Bonneville ANDENNE", "5300" },
                    { 312, "Bonsin SOMME-LEUZE", "5377" },
                    { 313, "Booischot HEIST-OP-DEN-BERG", "2221" },
                    { 314, "Booitshoeke VEURNE", "8630" },
                    { 315, "BOOM BOOM", "2850" },
                    { 316, "Boorsem MAASMECHELEN", "3631" },
                    { 317, "BOORTMEERBEEK BOORTMEERBEEK", "3190" },
                    { 318, "Borchtlombeek ROOSDAAL", "1761" },
                    { 330, "Bossut-Gottechain GREZ-DOICEAU", "1390" },
                    { 319, "Borgerhout ANTWERPEN", "2140" },
                    { 321, "Borlez FAIMES", "4317" },
                    { 322, "Borlo GINGELOM", "3891" },
                    { 323, "Borlon DURBUY", "6941" },
                    { 324, "BORNEM BORNEM", "2880" },
                    { 325, "Bornival NIVELLES", "1404" },
                    { 326, "BORSBEEK BORSBEEK", "2150" },
                    { 327, "Borsbeke HERZELE", "9552" },
                    { 328, "Bossi�re GEMBLOUX", "5032" },
                    { 320, "BORGLOON BORGLOON", "3840" },
                    { 265, "Binkom LUBBEEK", "3211" },
                    { 264, "Binderveld NIEUWERKERKEN", "3850" },
                    { 263, "BINCHE BINCHE", "7130" },
                    { 200, "Bellecourt MANAGE", "7170" },
                    { 201, "Bellefontaine BI�VRE", "5555" },
                    { 202, "Bellefontaine TINTIGNY", "6730" },
                    { 203, "Bellegem KORTRIJK", "8510" },
                    { 204, "Bellem AALTER", "9881" },
                    { 205, "Bellevaux BOUILLON", "6834" },
                    { 206, "Bellevaux-Ligneuville MALMEDY", "4960" },
                    { 207, "Bellingen PEPINGEN", "1674" },
                    { 199, "Bellaire BEYNE-HEUSAY", "4610" },
                    { 208, "BELOEIL BELOEIL", "7970" },
                    { 210, "Ben-Ahin HUY", "4500" },
                    { 211, "Bende DURBUY", "6941" },
                    { 212, "Berbroek HERK-DE-STAD", "3540" },
                    { 213, "Berchem ANTWERPEN", "2600" },
                    { 214, "Berchem KLUISBERGEN", "9690" },
                    { 215, "Berendrecht ANTWERPEN", "2040" },
                    { 216, "Berg KAMPENHOUT", "1910" },
                    { 217, "Berg TONGEREN", "3700" },
                    { 209, "Belsele SINT-NIKLAAS", "9111" },
                    { 218, "Bergilers OREYE", "4360" },
                    { 198, "Belgrade NAMUR", "5001" },
                    { 196, "BEKKEVOORT BEKKEVOORT", "3460" },
                    { 178, "Beauwelz MOMIGNIES", "6594" },
                    { 179, "B�clers TOURNAI", "7532" },
                    { 180, "Beek BREE", "3960" },
                    { 181, "Beerlegem ZWALM", "9630" },
                    { 182, "BEERNEM BEERNEM", "8730" },
                    { 183, "BEERSE BEERSE", "2340" },
                    { 184, "BEERSEL BEERSEL", "1650" },
                    { 185, "Beerst DIKSMUIDE", "8600" },
                    { 197, "Belgische Senaat Belgische Senaat", "1009" },
                    { 186, "Beert PEPINGEN", "1673" },
                    { 188, "Beerzel PUTTE", "2580" },
                    { 189, "Beez NAMUR", "5000" },
                    { 190, "Beffe RENDEUX", "6987" },
                    { 191, "BEGIJNENDIJK BEGIJNENDIJK", "3130" },
                    { 192, "Beho GOUVY", "6672" },
                    { 193, "Beigem GRIMBERGEN", "1852" },
                    { 194, "Bekegem ICHTEGEM", "8480" },
                    { 195, "Bekkerzeel ASSE", "1730" },
                    { 187, "Beervelde LOCHRISTI", "9080" },
                    { 219, "BERINGEN BERINGEN", "3580" },
                    { 220, "BERLAAR BERLAAR", "2590" },
                    { 221, "BERLARE BERLARE", "9290" },
                    { 245, "Beverst BILZEN", "3740" },
                    { 246, "BEYNE-HEUSAY BEYNE-HEUSAY", "4610" },
                    { 247, "Bienne-Lez-Happart LOBBES", "6543" },
                    { 248, "BIERBEEK BIERBEEK", "3360" },
                    { 249, "Bierc�e THUIN", "6533" },
                    { 250, "Bierges WAVRE", "1301" },
                    { 251, "Bierghes REBECQ", "1430" },
                    { 252, "Bierset GR�CE-HOLLOGNE", "4460" },
                    { 244, "Beverlo BERINGEN", "3581" },
                    { 253, "Bierwart FERNELMONT", "5380" },
                    { 255, "Biesme-Sous-Thuin THUIN", "6531" },
                    { 256, "Biesmer�e METTET", "5640" },
                    { 257, "BI�VRE BI�VRE", "5555" },
                    { 258, "Biez GREZ-DOICEAU", "1390" },
                    { 259, "Bihain VIELSALM", "6690" },
                    { 260, "Bikschote LANGEMARK-POELKAPELLE", "8920" },
                    { 261, "Bilstain LIMBOURG", "4831" },
                    { 262, "BILZEN BILZEN", "3740" },
                    { 254, "Biesme METTET", "5640" },
                    { 243, "BEVEREN-WAAS BEVEREN-WAAS", "9120" },
                    { 242, "Beveren-Aan-De-Ijzer ALVERINGEM", "8691" },
                    { 241, "Beveren ROESELARE", "8800" }
                });

            migrationBuilder.InsertData(
                table: "ZipCode",
                columns: new[] { "Id", "City", "Code" },
                values: new object[,]
                {
                    { 222, "Berlingen WELLEN", "3830" },
                    { 223, "BERLOZ BERLOZ", "4257" },
                    { 224, "Berneau DALHEM", "4607" },
                    { 225, "BERNISSART BERNISSART", "7320" },
                    { 226, "Bersillies-L'Abbaye ERQUELINNES", "6560" },
                    { 227, "BERTEM BERTEM", "3060" },
                    { 228, "BERTOGNE BERTOGNE", "6687" },
                    { 229, "Bertr�e HANNUT", "4280" },
                    { 230, "BERTRIX BERTRIX", "6880" },
                    { 231, "Berz�e WALCOURT", "5651" },
                    { 232, "Beselare ZONNEBEKE", "8980" },
                    { 233, "Betekom BEGIJNENDIJK", "3130" },
                    { 234, "Bettincourt WAREMME", "4300" },
                    { 235, "Beuzet GEMBLOUX", "5030" },
                    { 236, "Bevel NIJLEN", "2560" },
                    { 237, "BEVER BEVER", "1547" },
                    { 238, "Beverc� MALMEDY", "4960" },
                    { 239, "Bevere OUDENAARDE", "9700" },
                    { 240, "Beveren WAREGEM", "8791" },
                    { 352, "Bovenistier WAREMME", "4300" },
                    { 705, "Felenne BEAURAING", "5570" },
                    { 706, "Feluy SENEFFE", "7181" },
                    { 707, "Feneur DALHEM", "4607" },
                    { 1172, "Jemeppe-Sur-Meuse SERAING", "4101" },
                    { 1173, "JEMEPPE-SUR-SAMBRE JEMEPPE-SUR-SAMBRE", "5190" },
                    { 1174, "Jeneffe DONCEEL", "4357" },
                    { 1175, "Jeneffe HAVELANGE", "5370" },
                    { 1176, "Jesseren BORGLOON", "3840" },
                    { 1177, "JETTE JETTE", "1090" },
                    { 1178, "Jeuk GINGELOM", "3890" },
                    { 1179, "JODOIGNE JODOIGNE", "1370" },
                    { 1171, "Jemelle Jemelle", "5589" },
                    { 1180, "Jodoigne-Souveraine JODOIGNE", "1370" },
                    { 1182, "Joncret GERPINNES", "6280" },
                    { 1183, "Jul�mont HERVE", "4650" },
                    { 1184, "Jumet CHARLEROI", "6040" },
                    { 1185, "Jupille-Sur-Meuse LI�GE", "4020" },
                    { 1186, "JUPRELLE JUPRELLE", "4450" },
                    { 1187, "JURBISE JURBISE", "7050" },
                    { 1188, "Juseret VAUX-SUR-S�RE", "6642" },
                    { 1189, "Kaaskerke DIKSMUIDE", "8600" },
                    { 1181, "Jollain-Merlin BRUNEHAUT", "7620" },
                    { 1190, "Kachtem IZEGEM", "8870" },
                    { 1170, "Jemelle ROCHEFORT", "5580" },
                    { 1168, "Jehonville BERTRIX", "6880" },
                    { 1150, "Ivoz-Ramet FL�MALLE", "4400" },
                    { 1151, "IZEGEM IZEGEM", "8870" },
                    { 1152, "Izel CHINY", "6810" },
                    { 1153, "Izenberge ALVERINGEM", "8691" },
                    { 1154, "Izier DURBUY", "6941" },
                    { 1155, "JABBEKE JABBEKE", "8490" },
                    { 1156, "JALHAY JALHAY", "4845" },
                    { 1157, "Jallet OHEY", "5354" },
                    { 1169, "Jemappes MONS", "7012" },
                    { 1158, "Jamagne PHILIPPEVILLE", "5600" },
                    { 1160, "Jamiolle PHILIPPEVILLE", "5600" },
                    { 1161, "Jamioulx HAM-SUR-HEURE", "6120" },
                    { 1162, "Jamoigne CHINY", "6810" },
                    { 1163, "Jandrain-Jandrenouille ORP-JAUCHE", "1350" },
                    { 1164, "Jauche ORP-JAUCHE", "1350" },
                    { 1165, "Jauchelette JODOIGNE", "1370" },
                    { 1166, "Javingue BEAURAING", "5570" },
                    { 1167, "Jehay AMAY", "4540" },
                    { 1159, "Jambes NAMUR", "5100" },
                    { 1149, "ITTRE ITTRE", "1460" },
                    { 1191, "Kaggevinne DIEST", "3293" },
                    { 1193, "Kalken LAARNE", "9270" },
                    { 1216, "Kerkom-Bij-Sint-Truiden SINT-TRUIDEN", "3800" },
                    { 1217, "Kerksken HAALTERT", "9451" },
                    { 1218, "Kermt HASSELT", "3510" },
                    { 1219, "Kerniel BORGLOON", "3840" },
                    { 1220, "Kersbeek-Miskom KORTENAKEN", "3472" },
                    { 1221, "Kessel NIJLEN", "2560" },
                    { 1222, "Kessel Lo LEUVEN", "3010" },
                    { 1223, "Kessenich KINROOI", "3640" },
                    { 1215, "Kerkom BOUTERSEM", "3370" },
                    { 1224, "Kester GOOIK", "1755" },
                    { 1226, "Keumi�e SAMBREVILLE", "5060" },
                    { 1227, "Kieldrecht BEVEREN-WAAS", "9130" },
                    { 1228, "KINROOI KINROOI", "3640" },
                    { 1229, "Klein-Gelmen HEERS", "3870" },
                    { 1230, "Kleine-Brogel PEER", "3990" },
                    { 1231, "Kleine-Spouwen BILZEN", "3740" },
                    { 1232, "Klemskerke DE HAAN", "8420" },
                    { 1233, "Klerken HOUTHULST", "8650" },
                    { 1225, "Kettenis EUPEN", "4701" },
                    { 1192, "Kain TOURNAI", "7540" },
                    { 1214, "Kerkhove AVELGEM", "8581" },
                    { 1212, "Kemmel HEUVELLAND", "8956" },
                    { 1194, "Kallo BEVEREN-WAAS", "9120" },
                    { 1195, "Kallo BEVEREN-WAAS", "9130" },
                    { 1196, "KALMTHOUT KALMTHOUT", "2920" },
                    { 1197, "Kamer van Volksvertegenwoordigers Kamer van Volksvertegenwoordigers", "1008" },
                    { 1198, "KAMPENHOUT KAMPENHOUT", "1910" },
                    { 1199, "Kanegem TIELT", "8700" },
                    { 1200, "Kanne RIEMST", "3770" },
                    { 1201, "KAPELLE-OP-DEN-BOS KAPELLE-OP-DEN-BOS", "1880" },
                    { 1213, "Kemzeke STEKENE", "9190" },
                    { 1202, "KAPELLEN KAPELLEN", "2950" },
                    { 1204, "KAPRIJKE KAPRIJKE", "9970" },
                    { 1205, "Kaster ANZEGEM", "8572" },
                    { 1206, "KASTERLEE KASTERLEE", "2460" },
                    { 1207, "Kaulille BOCHOLT", "3950" },
                    { 1208, "KEERBERGEN KEERBERGEN", "3140" },
                    { 1209, "Keiem DIKSMUIDE", "8600" },
                    { 1210, "KELMIS KELMIS", "4720" },
                    { 1211, "Kemexhe CRISN�E", "4367" },
                    { 1203, "Kapellen GLABBEEK", "3381" },
                    { 1234, "KLUISBERGEN KLUISBERGEN", "9690" },
                    { 1148, "Itterbeek DILBEEK", "1701" },
                    { 1146, "Isnes GEMBLOUX", "5032" },
                    { 1084, "Hombourg PLOMBI�RES", "4852" },
                    { 1085, "Hompr� VAUX-SUR-S�RE", "6640" },
                    { 1086, "Hondelange MESSANCY", "6780" },
                    { 1087, "Honnay BEAURAING", "5570" },
                    { 1088, "HONNELLES HONNELLES", "7387" },
                    { 1089, "HOOGLEDE HOOGLEDE", "8830" },
                    { 1090, "Hoogstade ALVERINGEM", "8690" },
                    { 1091, "HOOGSTRATEN HOOGSTRATEN", "2320" },
                    { 1083, "Hombeek MECHELEN", "2811" },
                    { 1092, "HOREBEKE HOREBEKE", "9667" },
                    { 1094, "Hornu BOUSSU", "7301" },
                    { 1095, "Horpmaal HEERS", "3870" },
                    { 1096, "Horrues SOIGNIES", "7060" },
                    { 1097, "HOTTON HOTTON", "6990" },
                    { 1098, "Houdemont HABAY", "6724" },
                    { 1099, "Houdeng-Aimeries LA LOUVI�RE", "7110" },
                    { 1100, "Houdeng-Goegnies LA LOUVI�RE", "7110" },
                    { 1101, "Houdremont GEDINNE", "5575" },
                    { 1093, "Horion-Hoz�mont GR�CE-HOLLOGNE", "4460" },
                    { 1102, "HOUFFALIZE HOUFFALIZE", "6660" },
                    { 1082, "HOLSBEEK HOLSBEEK", "3220" },
                    { 1080, "Hollogne-Aux-Pierres GR�CE-HOLLOGNE", "4460" },
                    { 1062, "Hodeige REMICOURT", "4351" },
                    { 1063, "Hodister RENDEUX", "6987" },
                    { 1064, "Hody ANTHISNES", "4162" },
                    { 1065, "HOEGAARDEN HOEGAARDEN", "3320" },
                    { 1066, "HOEILAART HOEILAART", "1560" },
                    { 1067, "Hoeke DAMME", "8340" },
                    { 1068, "Hoelbeek BILZEN", "3746" },
                    { 1069, "Hoeleden KORTENAKEN", "3471" },
                    { 1081, "Hollogne-Sur-Geer GEER", "4250" },
                    { 1070, "Hoepertingen BORGLOON", "3840" },
                    { 1072, "Hoevenen STABROEK", "2940" },
                    { 1073, "Hofstade ZEMST", "1981" },
                    { 1074, "Hofstade AALST", "9308" },
                    { 1075, "Hogne SOMME-LEUZE", "5377" },
                    { 1076, "Hognoul AWANS", "4342" },
                    { 1077, "Hollain BRUNEHAUT", "7620" },
                    { 1078, "Hollange FAUVILLERS", "6637" },
                    { 1079, "Hollebeke IEPER", "8902" },
                    { 1071, "HOESELT HOESELT", "3730" },
                    { 1147, "Itegem HEIST-OP-DEN-BERG", "2222" },
                    { 1103, "Hour HOUYET", "5563" },
                    { 1105, "Houtain-Le-Val GENAPPE", "1476" },
                    { 1128, "Hulste HARELBEKE", "8531" },
                    { 1129, "Humain MARCHE-EN-FAMENNE", "6900" },
                    { 1130, "Humbeek GRIMBERGEN", "1851" },
                    { 1131, "Hundelgem ZWALM", "9630" },
                    { 1132, "Huppaye RAMILLIES", "1367" },
                    { 1133, "HUY HUY", "4500" },
                    { 1134, "Hyon MONS", "7022" },
                    { 1135, "ICHTEGEM ICHTEGEM", "8480" },
                    { 1127, "Hulsonniaux HOUYET", "5560" },
                    { 1136, "Iddergem DENDERLEEUW", "9472" },
                    { 1138, "IEPER IEPER", "8900" },
                    { 1139, "Impe LEDE", "9340" },
                    { 1140, "INCOURT INCOURT", "1315" },
                    { 1141, "INGELMUNSTER INGELMUNSTER", "8770" },
                    { 1142, "Ingooigem ANZEGEM", "8570" },
                    { 1143, "International press center International press center", "1041" },
                    { 1144, "Irchonwelz ATH", "7801" },
                    { 1145, "Isi�res ATH", "7822" },
                    { 1137, "Idegem GERAARDSBERGEN", "9506" },
                    { 1104, "Housse BL�GNY", "4671" },
                    { 1126, "HULSHOUT HULSHOUT", "2235" },
                    { 1124, "Huizingen BEERSEL", "1654" },
                    { 1106, "Houtain-Saint-Sim�on OUPEYE", "4682" },
                    { 1107, "Houtaing ATH", "7812" },
                    { 1108, "Houtave ZUIENKERKE", "8377" },
                    { 1109, "Houtem VEURNE", "8630" },
                    { 1110, "Houthalen HOUTHALEN-HELCHTEREN", "3530" },
                    { 1111, "HOUTHALEN-HELCHTEREN HOUTHALEN-HELCHTEREN", "3530" },
                    { 1112, "Houthem KOMEN-WAASTEN", "7781" },
                    { 1113, "HOUTHULST HOUTHULST", "8650" },
                    { 1125, "HULDENBERG HULDENBERG", "3040" },
                    { 1114, "Houtvenne HULSHOUT", "2235" },
                    { 1116, "Houx YVOIR", "5530" },
                    { 1117, "HOUYET HOUYET", "5560" },
                    { 1118, "HOVE HOVE", "2540" },
                    { 1119, "Hoves SILLY", "7830" },
                    { 1120, "Howardries BRUNEHAUT", "7624" },
                    { 1121, "Huccorgne WANZE", "4520" },
                    { 1122, "Huise KRUISEM", "9750" },
                    { 1123, "Huissignies CHI�VRES", "7950" },
                    { 1115, "Houwaart TIELT-WINGE", "3390" },
                    { 1235, "Kluizen EVERGEM", "9940" },
                    { 1236, "Knesselare AALTER", "9910" },
                    { 1237, "Knokke KNOKKE-HEIST", "8300" },
                    { 1349, "Lembeke KAPRIJKE", "9971" },
                    { 1350, "Lemberge MERELBEKE", "9820" },
                    { 1351, "LENDELEDE LENDELEDE", "8860" },
                    { 1352, "LENNIK LENNIK", "1750" },
                    { 1353, "LENS LENS", "7870" },
                    { 1354, "Lens-Saint-Remy HANNUT", "4280" },
                    { 1355, "Lens-Saint-Servais GEER", "4250" },
                    { 1356, "Lens-Sur-Geer OREYE", "4360" },
                    { 1348, "Lembeek HALLE", "1502" },
                    { 1357, "LEOPOLDSBURG LEOPOLDSBURG", "3970" },
                    { 1359, "LES BONS VILLERS LES BONS VILLERS", "6210" },
                    { 1360, "Les Bulles CHINY", "6811" },
                    { 1361, "Les Hayons BOUILLON", "6830" },
                    { 1362, "Les Waleffes FAIMES", "4317" },
                    { 1363, "Lesdain BRUNEHAUT", "7621" },
                    { 1364, "LESSINES LESSINES", "7860" },
                    { 1365, "Lessive ROCHEFORT", "5580" },
                    { 1366, "Lesterny NASSOGNE", "6953" },
                    { 1358, "Les Avins CLAVIER", "4560" },
                    { 1367, "Lesve PROFONDEVILLE", "5170" },
                    { 1347, "Leke DIKSMUIDE", "8600" },
                    { 1345, "Leignon CINEY", "5590" },
                    { 1327, "Lavaux-Sainte-Anne ROCHEFORT", "5580" },
                    { 1328, "Lavoir H�RON", "4217" },
                    { 1329, "Le Mesnil VIROINVAL", "5670" },
                    { 1330, "LE ROEULX LE ROEULX", "7070" },
                    { 1331, "Le Roux FOSSES-LA-VILLE", "5070" },
                    { 1332, "LEBBEKE LEBBEKE", "9280" },
                    { 1333, "LEDE LEDE", "9340" },
                    { 1334, "Ledeberg GENT", "9050" },
                    { 1346, "Leisele ALVERINGEM", "8691" },
                    { 1335, "LEDEGEM LEDEGEM", "8880" },
                    { 1337, "Leerbeek GOOIK", "1755" },
                    { 1338, "Leernes FONTAINE-L'EV�QUE", "6142" },
                    { 1339, "Leers-Et-Fosteau THUIN", "6530" },
                    { 1340, "Leers-Nord ESTAIMPUIS", "7730" },
                    { 1341, "Leest MECHELEN", "2811" },
                    { 1342, "Leeuwergem ZOTTEGEM", "9620" },
                    { 1343, "Leffinge MIDDELKERKE", "8432" },
                    { 1344, "L�GLISE L�GLISE", "6860" },
                    { 1336, "Leefdaal BERTEM", "3061" },
                    { 1326, "Lavacherie SAINTE-ODE", "6681" },
                    { 1368, "Lettelingen EDINGEN", "7850" },
                    { 1370, "Leugnies BEAUMONT", "6500" },
                    { 1393, "LIEVEGEM LIEVEGEM", "9930" },
                    { 1394, "Liezele PUURS-SINT-AMANDS", "2870" },
                    { 1395, "Ligne ATH", "7812" },
                    { 1396, "Ligney GEER", "4254" },
                    { 1397, "Ligny SOMBREFFE", "5140" },
                    { 1398, "LILLE LILLE", "2275" },
                    { 1399, "Lillo ANTWERPEN", "2040" },
                    { 1400, "Lillois-Witterz�e BRAINE-L'ALLEUD", "1428" },
                    { 1392, "Liers HERSTAL", "4042" },
                    { 1401, "Limal WAVRE", "1300" },
                    { 1403, "Limelette OTTIGNIES-LOUVAIN-LA-NEUVE", "1342" },
                    { 1404, "Limerl� GOUVY", "6670" },
                    { 1405, "Limont DONCEEL", "4357" },
                    { 1406, "LINCENT LINCENT", "4287" },
                    { 1407, "Linden LUBBEEK", "3210" },
                    { 1408, "LINKEBEEK LINKEBEEK", "1630" },
                    { 1409, "Linkhout LUMMEN", "3560" },
                    { 1410, "Linsmeau H�L�CINE", "1357" },
                    { 1402, "LIMBOURG LIMBOURG", "4830" },
                    { 1369, "Letterhoutem SINT-LIEVENS-HOUTEM", "9521" },
                    { 1391, "Liernu EGHEZ�E", "5310" },
                    { 1389, "LIERDE LIERDE", "9570" },
                    { 1371, "Leupegem OUDENAARDE", "9700" },
                    { 1372, "Leut MAASMECHELEN", "3630" },
                    { 1373, "LEUVEN LEUVEN", "3000" },
                    { 1374, "Leuze EGHEZ�E", "5310" },
                    { 1375, "LEUZE-EN-HAINAUT LEUZE-EN-HAINAUT", "7900" },
                    { 1376, "Leval-Chaudeville BEAUMONT", "6500" },
                    { 1377, "Leval-Trahegnies BINCHE", "7134" },
                    { 1378, "Liberchies PONT-�-CELLES", "6238" },
                    { 1390, "LIERNEUX LIERNEUX", "4990" },
                    { 1379, "LIBIN LIBIN", "6890" },
                    { 1381, "Lichtaart KASTERLEE", "2460" },
                    { 1382, "LICHTERVELDE LICHTERVELDE", "8810" },
                    { 1383, "LIEDEKERKE LIEDEKERKE", "1770" },
                    { 1384, "Lieferinge NINOVE", "9400" },
                    { 1385, "LI�GE LI�GE", "4000" },
                    { 1386, "LI�GE LI�GE", "4020" },
                    { 1387, "Li�ge X Li�ge X", "4099" },
                    { 1388, "LIER LIER", "2500" },
                    { 1380, "LIBRAMONT-CHEVIGNY LIBRAMONT-CHEVIGNY", "6800" },
                    { 1325, "Lauwe MENEN", "8930" },
                    { 1324, "Lauw TONGEREN", "3700" },
                    { 1323, "Latour VIRTON", "6761" },
                    { 1260, "Kortijs GINGELOM", "3890" },
                    { 1261, "KORTRIJK KORTRIJK", "8500" },
                    { 1262, "Kortrijk-Dutsel HOLSBEEK", "3220" },
                    { 1263, "Kozen NIEUWERKERKEN", "3850" },
                    { 1264, "KRAAINEM KRAAINEM", "1950" },
                    { 1265, "Krombeke POPERINGE", "8972" },
                    { 1266, "KRUIBEKE KRUIBEKE", "9150" },
                    { 1267, "KRUISEM KRUISEM", "9770" },
                    { 1259, "KORTESSEM KORTESSEM", "3720" },
                    { 1268, "Kruishoutem KRUISEM", "9770" },
                    { 1270, "Kuringen HASSELT", "3511" },
                    { 1271, "Kuttekoven BORGLOON", "3840" },
                    { 1272, "KUURNE KUURNE", "8520" },
                    { 1273, "Kwaadmechelen HAM", "3945" },
                    { 1274, "Kwaremont KLUISBERGEN", "9690" },
                    { 1275, "L'Ecluse BEAUVECHAIN", "1320" },
                    { 1276, "L'Escaill�re CHIMAY", "6464" },
                    { 1277, "La Bouverie FRAMERIES", "7080" },
                    { 1269, "Kumtich TIENEN", "3300" },
                    { 1278, "LA BRUY�RE LA BRUY�RE", "5080" },
                    { 1258, "KORTENBERG KORTENBERG", "3070" },
                    { 1256, "KORTEMARK KORTEMARK", "8610" },
                    { 1238, "KNOKKE-HEIST KNOKKE-HEIST", "8300" },
                    { 1239, "Kobbegem ASSE", "1730" },
                    { 1240, "KOEKELARE KOEKELARE", "8680" },
                    { 1241, "KOEKELBERG KOEKELBERG", "1081" },
                    { 1242, "Koersel BERINGEN", "3582" },
                    { 1243, "KOKSIJDE KOKSIJDE", "8670" },
                    { 1244, "Kolmont TONGEREN", "3700" },
                    { 1245, "Kolmont BORGLOON", "3840" },
                    { 1257, "KORTENAKEN KORTENAKEN", "3470" },
                    { 1246, "Komen KOMEN-WAASTEN", "7780" },
                    { 1248, "Koningshooikt LIER", "2500" },
                    { 1249, "Koninksem TONGEREN", "3700" },
                    { 1250, "KONTICH KONTICH", "2550" },
                    { 1251, "Kooigem KORTRIJK", "8510" },
                    { 1252, "Koolkerke BRUGGE", "8000" },
                    { 1253, "Koolskamp ARDOOIE", "8851" },
                    { 1254, "Korbeek-Dijle BERTEM", "3060" },
                    { 1255, "Korbeek-Lo BIERBEEK", "3360" },
                    { 1247, "KOMEN-WAASTEN KOMEN-WAASTEN", "7780" },
                    { 1279, "La Glanerie RUMES", "7611" },
                    { 1280, "La Gleize STOUMONT", "4987" },
                    { 1281, "La Hestre MANAGE", "7170" },
                    { 1305, "Landelies MONTIGNY-LE-TILLEUL", "6111" },
                    { 1306, "LANDEN LANDEN", "3400" },
                    { 1307, "Landenne ANDENNE", "5300" },
                    { 1308, "Landskouter OOSTERZELE", "9860" },
                    { 1309, "Laneffe WALCOURT", "5651" },
                    { 1310, "Langdorp AARSCHOT", "3201" },
                    { 1311, "Langemark LANGEMARK-POELKAPELLE", "8920" },
                    { 1312, "LANGEMARK-POELKAPELLE LANGEMARK-POELKAPELLE", "8920" },
                    { 1304, "Landegem DEINZE", "9850" },
                    { 1313, "Lanklaar DILSEN-STOKKEM", "3650" },
                    { 1315, "Lantin JUPRELLE", "4450" },
                    { 1316, "Lantremange WAREMME", "4300" },
                    { 1317, "Laplaigne BRUNEHAUT", "7622" },
                    { 1318, "Lapscheure DAMME", "8340" },
                    { 1319, "LASNE LASNE", "1380" },
                    { 1320, "Lasne-Chapelle-Saint-Lambert LASNE", "1380" },
                    { 1321, "Lathuy JODOIGNE", "1370" },
                    { 1322, "Latinne BRAIVES", "4261" },
                    { 1314, "Lanquesaint ATH", "7800" },
                    { 1303, "Lanaye VIS�", "4600" },
                    { 1302, "LANAKEN LANAKEN", "3620" },
                    { 1301, "Lampernisse DIKSMUIDE", "8600" },
                    { 1282, "LA HULPE LA HULPE", "1310" },
                    { 1283, "LA LOUVI�RE LA LOUVI�RE", "7100" },
                    { 1284, "La Reid THEUX", "4910" },
                    { 1285, "LA ROCHE-EN-ARDENNE LA ROCHE-EN-ARDENNE", "6980" },
                    { 1286, "LAAKDAL LAAKDAL", "2430" },
                    { 1287, "Laar LANDEN", "3400" },
                    { 1288, "LAARNE LAARNE", "9270" },
                    { 1289, "Labuissi�re MERBES-LE-CH�TEAU", "6567" },
                    { 1290, "Lacuisine FLORENVILLE", "6821" },
                    { 1291, "Ladeuze CHI�VRES", "7950" },
                    { 1292, "Lafor�t VRESSE-SUR-SEMOIS", "5550" },
                    { 1293, "Lahamaide ELLEZELLES", "7890" },
                    { 1294, "Laken BRUSSEL", "1020" },
                    { 1295, "Lamain TOURNAI", "7522" },
                    { 1296, "Lambermont VERVIERS", "4800" },
                    { 1297, "Lambusart FLEURUS", "6220" },
                    { 1298, "Lamine REMICOURT", "4350" },
                    { 1299, "Lamontz�e BURDINNE", "4210" },
                    { 1300, "Lamorteau ROUVROY", "6767" },
                    { 1061, "Hoboken ANTWERPEN", "2660" },
                    { 1060, "Hives LA ROCHE-EN-ARDENNE", "6984" },
                    { 1059, "Hingeon FERNELMONT", "5380" },
                    { 1058, "Hingene BORNEM", "2880" },
                    { 819, "Gierle LILLE", "2275" },
                    { 820, "Gijverinkhove ALVERINGEM", "8691" },
                    { 821, "Gijzegem AALST", "9308" },
                    { 822, "Gijzelbrechtegem ANZEGEM", "8570" },
                    { 823, "Gijzenzele OOSTERZELE", "9860" },
                    { 824, "Gilly CHARLEROI", "6060" },
                    { 825, "Gimn�e DOISCHE", "5680" },
                    { 826, "GINGELOM GINGELOM", "3890" },
                    { 818, "Gibecq ATH", "7823" },
                    { 827, "GISTEL GISTEL", "8470" },
                    { 829, "Givry QU�VY", "7041" },
                    { 830, "Glabais GENAPPE", "1473" },
                    { 831, "GLABBEEK GLABBEEK", "3380" },
                    { 832, "Glain LI�GE", "4000" },
                    { 833, "Gleixhe FL�MALLE", "4400" },
                    { 834, "Glimes INCOURT", "1315" },
                    { 835, "Glons BASSENGE", "4690" },
                    { 836, "Gochen�e DOISCHE", "5680" },
                    { 828, "Gits HOOGLEDE", "8830" },
                    { 837, "Godarville CHAPELLE-LEZ-HERLAIMONT", "7160" },
                    { 817, "Ghoy LESSINES", "7863" },
                    { 815, "Ghislenghien ATH", "7822" },
                    { 797, "Gemmenich PLOMBI�RES", "4851" },
                    { 798, "GENAPPE GENAPPE", "1470" },
                    { 799, "GENK GENK", "3600" },
                    { 800, "Genly QU�VY", "7040" },
                    { 801, "Genoelselderen RIEMST", "3770" },
                    { 802, "GENT GENT", "9000" },
                    { 803, "Gent X Gent X", "9099" },
                    { 804, "Gentbrugge GENT", "9050" },
                    { 816, "Ghlin MONS", "7011" },
                    { 805, "Gentinnes CHASTRE", "1450" },
                    { 807, "GERAARDSBERGEN GERAARDSBERGEN", "9500" },
                    { 808, "Gerdingen BREE", "3960" },
                    { 809, "G�rin ONHAYE", "5524" },
                    { 810, "G�rompont RAMILLIES", "1367" },
                    { 811, "G�rouville MEIX-DEVANT-VIRTON", "6769" },
                    { 812, "GERPINNES GERPINNES", "6280" },
                    { 813, "Gestel BERLAAR", "2590" },
                    { 814, "GESVES GESVES", "5340" },
                    { 806, "Genval RIXENSART", "1332" },
                    { 796, "GEMBLOUX GEMBLOUX", "5030" },
                    { 838, "Godinne YVOIR", "5530" },
                    { 840, "Go� LIMBOURG", "4834" },
                    { 863, "GR�CE-HOLLOGNE GR�CE-HOLLOGNE", "4460" },
                    { 864, "Graide BI�VRE", "5555" },
                    { 865, "Grammene DEINZE", "9800" },
                    { 866, "Grand-Axhe WAREMME", "4300" },
                    { 867, "Grand-Hallet HANNUT", "4280" },
                    { 868, "Grand-Halleux VIELSALM", "6698" },
                    { 869, "Grand-Leez GEMBLOUX", "5031" },
                    { 870, "Grand-Manil GEMBLOUX", "5030" },
                    { 862, "Gr�ce-Berleur GR�CE-HOLLOGNE", "4460" },
                    { 871, "Grand-Rechain HERVE", "4650" },
                    { 873, "Grand-Rosi�re-Hottomont RAMILLIES", "1367" },
                    { 874, "Grandglise BELOEIL", "7973" },
                    { 875, "Grandhan DURBUY", "6940" },
                    { 876, "Grandm�nil MANHAY", "6960" },
                    { 877, "Grandmetz LEUZE-EN-HAINAUT", "7900" },
                    { 878, "Grandrieu SIVRY-RANCE", "6470" },
                    { 879, "Grandville OREYE", "4360" },
                    { 880, "Grandvoir NEUFCH�TEAU", "6840" },
                    { 872, "Grand-Reng ERQUELINNES", "6560" },
                    { 839, "Godveerdegem ZOTTEGEM", "9620" },
                    { 861, "Goz�e THUIN", "6534" },
                    { 859, "GOUVY GOUVY", "6670" },
                    { 841, "Goeferdinge GERAARDSBERGEN", "9500" },
                    { 842, "Goegnies-Chauss�e QU�VY", "7040" },
                    { 843, "Goesnes OHEY", "5353" },
                    { 844, "Goetsenhoven TIENEN", "3300" },
                    { 845, "Gomz�-Andoumont SPRIMONT", "4140" },
                    { 846, "Gondregnies SILLY", "7830" },
                    { 847, "Gonrieux COUVIN", "5660" },
                    { 848, "Gontrode MELLE", "9090" },
                    { 860, "Gouy-Lez-Pi�ton COURCELLES", "6181" },
                    { 849, "GOOIK GOOIK", "1755" },
                    { 851, "Gorsem SINT-TRUIDEN", "3803" },
                    { 852, "Gosselies CHARLEROI", "6041" },
                    { 853, "Gotem BORGLOON", "3840" },
                    { 854, "Gottem DEINZE", "9800" },
                    { 855, "Gottignies LE ROEULX", "7070" },
                    { 856, "Gougnies GERPINNES", "6280" },
                    { 857, "Gourdinne WALCOURT", "5651" },
                    { 858, "Goutroux CHARLEROI", "6030" },
                    { 850, "Gors-Opleeuw BORGLOON", "3840" },
                    { 795, "Gembes DAVERDISSE", "6929" },
                    { 794, "Geluwe WERVIK", "8940" },
                    { 793, "Geluveld ZONNEBEKE", "8980" },
                    { 730, "FLORENVILLE FLORENVILLE", "6820" },
                    { 731, "Floriffoux FLOREFFE", "5150" },
                    { 732, "Flostoy HAVELANGE", "5370" },
                    { 733, "Focant BEAURAING", "5572" },
                    { 734, "FOD Mobiliteit FOD Mobiliteit", "1212" },
                    { 735, "Folx-Les-Caves ORP-JAUCHE", "1350" },
                    { 736, "FONTAINE-L'EV�QUE FONTAINE-L'EV�QUE", "6140" },
                    { 737, "Fontaine-Valmont MERBES-LE-CH�TEAU", "6567" },
                    { 729, "FLORENNES FLORENNES", "5620" },
                    { 738, "Fontenelle WALCOURT", "5650" },
                    { 740, "Fontenoy ANTOING", "7643" },
                    { 741, "Fooz AWANS", "4340" },
                    { 742, "Forchies-La-Marche FONTAINE-L'EV�QUE", "6141" },
                    { 743, "Forest FRASNES-LEZ-ANVAING", "7910" },
                    { 744, "For�t TROOZ", "4870" },
                    { 745, "Forge-Philippe MOMIGNIES", "6596" },
                    { 746, "Forges CHIMAY", "6464" },
                    { 747, "Forri�res NASSOGNE", "6953" },
                    { 739, "Fontenoille FLORENVILLE", "6820" },
                    { 748, "Forville FERNELMONT", "5380" },
                    { 728, "FLOREFFE FLOREFFE", "5150" },
                    { 726, "Fl�ne AMAY", "4540" },
                    { 708, "FERNELMONT FERNELMONT", "5380" },
                    { 709, "FERRI�RES FERRI�RES", "4190" },
                    { 710, "Feschaux BEAURAING", "5570" },
                    { 711, "FEXHE-LE-HAUT-CLOCHER FEXHE-LE-HAUT-CLOCHER", "4347" },
                    { 712, "Fexhe-Slins JUPRELLE", "4458" },
                    { 713, "Filot HAMOIR", "4181" },
                    { 714, "Finnevaux HOUYET", "5560" },
                    { 715, "Fize-Fontaine VILLERS-LE-BOUILLET", "4530" },
                    { 727, "Flor�e ASSESSE", "5334" },
                    { 716, "Fize-Le-Marsal CRISN�E", "4367" },
                    { 718, "Flavion FLORENNES", "5620" },
                    { 719, "Flawinne NAMUR", "5020" },
                    { 720, "FL�MALLE FL�MALLE", "4400" },
                    { 721, "Fl�malle-Grande FL�MALLE", "4400" },
                    { 722, "Fl�malle-Haute FL�MALLE", "4400" },
                    { 723, "Fl�nu MONS", "7012" },
                    { 724, "FL�RON FL�RON", "4620" },
                    { 725, "FLEURUS FLEURUS", "6220" },
                    { 717, "Flamierge BERTOGNE", "6686" },
                    { 749, "Fosse TROIS-PONTS", "4980" },
                    { 750, "FOSSES-LA-VILLE FOSSES-LA-VILLE", "5070" },
                    { 751, "Fouleng SILLY", "7830" },
                    { 775, "Furfooz DINANT", "5500" },
                    { 776, "Furnaux METTET", "5641" },
                    { 777, "Gaasbeek LENNIK", "1750" },
                    { 778, "Gages BRUGELETTE", "7943" },
                    { 779, "Gallaix LEUZE-EN-HAINAUT", "7906" },
                    { 780, "GALMAARDEN GALMAARDEN", "1570" },
                    { 781, "GANSHOREN GANSHOREN", "1083" },
                    { 782, "Gaurain-Ramecroix TOURNAI", "7530" },
                    { 774, "Fumal BRAIVES", "4260" },
                    { 783, "GAVERE GAVERE", "9890" },
                    { 785, "GEEL GEEL", "2440" },
                    { 786, "GEER GEER", "4250" },
                    { 787, "Geest-G�rompont-Petit-Rosi�re RAMILLIES", "1367" },
                    { 788, "GEETBETS GEETBETS", "3450" },
                    { 789, "Gelbress�e NAMUR", "5024" },
                    { 790, "Gelinden SINT-TRUIDEN", "3800" },
                    { 791, "Gellik LANAKEN", "3620" },
                    { 792, "Gelrode AARSCHOT", "3200" },
                    { 784, "GEDINNE GEDINNE", "5575" },
                    { 773, "Froyennes TOURNAI", "7503" },
                    { 772, "Fronville HOTTON", "6990" },
                    { 771, "Froidmont TOURNAI", "7504" },
                    { 752, "Fourbechies FROIDCHAPELLE", "6440" },
                    { 753, "Foy-Notre-Dame DINANT", "5504" },
                    { 754, "Fraipont TROOZ", "4870" },
                    { 755, "Fraire WALCOURT", "5650" },
                    { 756, "Fraiture TINLOT", "4557" },
                    { 757, "FRAMERIES FRAMERIES", "7080" },
                    { 758, "Framont PALISEUL", "6853" },
                    { 759, "Franc-Waret FERNELMONT", "5380" },
                    { 760, "Franchimont PHILIPPEVILLE", "5600" },
                    { 761, "Francorchamps STAVELOT", "4970" },
                    { 762, "Frani�re FLOREFFE", "5150" },
                    { 763, "Frasnes COUVIN", "5660" },
                    { 764, "FRASNES-LEZ-ANVAING FRASNES-LEZ-ANVAING", "7910" },
                    { 765, "Frasnes-Lez-Buissenal FRASNES-LEZ-ANVAING", "7911" },
                    { 766, "Frasnes-Lez-Gosselies LES BONS VILLERS", "6210" },
                    { 767, "Freloux FEXHE-LE-HAUT-CLOCHER", "4347" },
                    { 768, "Freux LIBRAMONT-CHEVIGNY", "6800" },
                    { 769, "FROIDCHAPELLE FROIDCHAPELLE", "6440" },
                    { 770, "Froidfontaine BEAURAING", "5576" },
                    { 881, "Grapfontaine NEUFCH�TEAU", "6840" },
                    { 1412, "LINTER LINTER", "3350" },
                    { 882, "Graty SILLY", "7830" },
                    { 884, "Grazen GEETBETS", "3450" },
                    { 996, "Heks HEERS", "3870" },
                    { 997, "Helchteren HOUTHALEN-HELCHTEREN", "3530" },
                    { 998, "Heldergem HAALTERT", "9450" },
                    { 999, "H�L�CINE H�L�CINE", "1357" },
                    { 1000, "Helen-Bos ZOUTLEEUW", "3440" },
                    { 1001, "Helkijn SPIERE-HELKIJN", "8587" },
                    { 1002, "Hellebecq SILLY", "7830" },
                    { 1003, "Hemelveerdegem LIERDE", "9571" },
                    { 995, "Hekelgem AFFLIGEM", "1790" },
                    { 1004, "HEMIKSEM HEMIKSEM", "2620" },
                    { 1006, "Hemptinne-Lez-Florennes FLORENNES", "5620" },
                    { 1007, "Hendrieken BORGLOON", "3840" },
                    { 1008, "Henis TONGEREN", "3700" },
                    { 1009, "Hennuy�res BRAINE-LE-COMTE", "7090" },
                    { 1010, "Henri-Chapelle WELKENRAEDT", "4841" },
                    { 1011, "Henripont BRAINE-LE-COMTE", "7090" },
                    { 1012, "HENSIES HENSIES", "7350" },
                    { 1013, "Heppen LEOPOLDSBURG", "3971" },
                    { 1005, "Hemptinne FERNELMONT", "5380" },
                    { 1014, "Heppenbach AMEL", "4771" },
                    { 994, "HEIST-OP-DEN-BERG HEIST-OP-DEN-BERG", "2220" },
                    { 992, "Heinsch ARLON", "6700" },
                    { 974, "Haut-Fays DAVERDISSE", "6929" },
                    { 975, "Haut-Ittre ITTRE", "1461" },
                    { 976, "Haut-Le-Wastia ANH�E", "5537" },
                    { 977, "Hautrage SAINT-GHISLAIN", "7334" },
                    { 978, "Havay QU�VY", "7041" },
                    { 979, "HAVELANGE HAVELANGE", "5370" },
                    { 980, "Haversin CINEY", "5590" },
                    { 981, "Havinnes TOURNAI", "7531" },
                    { 993, "Heist-Aan-Zee KNOKKE-HEIST", "8301" },
                    { 982, "Havr� MONS", "7021" },
                    { 984, "HECHTEL-EKSEL HECHTEL-EKSEL", "3940" },
                    { 985, "Heer HASTI�RE", "5543" },
                    { 986, "HEERS HEERS", "3870" },
                    { 987, "Hees BILZEN", "3740" },
                    { 988, "Heestert ZWEVEGEM", "8551" },
                    { 989, "Heffen MECHELEN", "2801" },
                    { 990, "Heikruis PEPINGEN", "1670" },
                    { 991, "Heindonk WILLEBROEK", "2830" },
                    { 983, "Hechtel HECHTEL-EKSEL", "3940" },
                    { 973, "Hauset RAEREN", "4730" },
                    { 1015, "Heppignies FLEURUS", "6220" },
                    { 1017, "Herchies JURBISE", "7050" },
                    { 1040, "Hertsberge OOSTKAMP", "8020" },
                    { 1041, "HERVE HERVE", "4650" },
                    { 1042, "HERZELE HERZELE", "9550" },
                    { 1043, "Heule KORTRIJK", "8501" },
                    { 1044, "Heure SOMME-LEUZE", "5377" },
                    { 1045, "Heure-Le-Romain OUPEYE", "4682" },
                    { 1046, "Heurne OUDENAARDE", "9700" },
                    { 1047, "Heusden HEUSDEN-ZOLDER", "3550" },
                    { 1039, "Herten WELLEN", "3831" },
                    { 1048, "Heusden DESTELBERGEN", "9070" },
                    { 1050, "Heusy VERVIERS", "4802" },
                    { 1051, "HEUVELLAND HEUVELLAND", "8950" },
                    { 1052, "Hever BOORTMEERBEEK", "3191" },
                    { 1053, "Heverlee LEUVEN", "3001" },
                    { 1054, "H�villers MONT-SAINT-GUIBERT", "1435" },
                    { 1055, "Heyd DURBUY", "6941" },
                    { 1056, "HighCo DATA HighCo DATA", "1733" },
                    { 1057, "Hillegem HERZELE", "9550" },
                    { 1049, "HEUSDEN-ZOLDER HEUSDEN-ZOLDER", "3550" },
                    { 1016, "HERBEUMONT HERBEUMONT", "6887" },
                    { 1038, "Hertain TOURNAI", "7522" },
                    { 1036, "HERSTAL HERSTAL", "4040" },
                    { 1018, "Herderen RIEMST", "3770" },
                    { 1019, "Herdersem AALST", "9310" },
                    { 1020, "HERENT HERENT", "3020" },
                    { 1021, "HERENTALS HERENTALS", "2200" },
                    { 1022, "HERENTHOUT HERENTHOUT", "2270" },
                    { 1023, "Herfelingen HERNE", "1540" },
                    { 1024, "Hergenrath KELMIS", "4728" },
                    { 1025, "H�rinnes-Lez-Pecq PECQ", "7742" },
                    { 1037, "HERSTAPPE HERSTAPPE", "3717" },
                    { 1026, "HERK-DE-STAD HERK-DE-STAD", "3540" },
                    { 1028, "Hermalle-Sous-Huy ENGIS", "4480" },
                    { 1029, "Herm�e OUPEYE", "4680" },
                    { 1030, "Hermeton-Sur-Meuse HASTI�RE", "5540" },
                    { 1031, "HERNE HERNE", "1540" },
                    { 1032, "H�RON H�RON", "4217" },
                    { 1033, "Herquegies FRASNES-LEZ-ANVAING", "7911" },
                    { 1034, "Herseaux MOESKROEN", "7712" },
                    { 1035, "HERSELT HERSELT", "2230" },
                    { 1027, "Hermalle-Sous-Argenteau OUPEYE", "4681" },
                    { 972, "Haulchin ESTINNES", "7120" },
                    { 971, "Hatrival SAINT-HUBERT", "6870" },
                    { 970, "Hasti�re-Par-Del� HASTI�RE", "5541" },
                    { 907, "HAACHT HAACHT", "3150" },
                    { 908, "HAALTERT HAALTERT", "9450" },
                    { 909, "Haasdonk BEVEREN-WAAS", "9120" },
                    { 910, "Haasrode OUD-HEVERLEE", "3053" },
                    { 911, "HABAY HABAY", "6720" },
                    { 912, "Habay-La-Neuve HABAY", "6720" },
                    { 913, "Habay-La-Vieille HABAY", "6723" },
                    { 914, "Habergy MESSANCY", "6782" },
                    { 906, "Gutshoven HEERS", "3870" },
                    { 915, "Haccourt OUPEYE", "4684" },
                    { 917, "Hacquegnies FRASNES-LEZ-ANVAING", "7911" },
                    { 918, "Haillot OHEY", "5351" },
                    { 919, "Haine-Saint-Paul LA LOUVI�RE", "7100" },
                    { 920, "Haine-Saint-Pierre LA LOUVI�RE", "7100" },
                    { 921, "Hainin HENSIES", "7350" },
                    { 922, "Hakendover TIENEN", "3300" },
                    { 923, "Halanzy AUBANGE", "6792" },
                    { 924, "HALEN HALEN", "3545" },
                    { 916, "Hachy HABAY", "6720" },
                    { 925, "Hallaar HEIST-OP-DEN-BERG", "2220" },
                    { 905, "Gullegem WEVELGEM", "8560" },
                    { 903, "Guigoven KORTESSEM", "3723" },
                    { 885, "Grembergen DENDERMONDE", "9200" },
                    { 886, "GREZ-DOICEAU GREZ-DOICEAU", "1390" },
                    { 887, "GRIMBERGEN GRIMBERGEN", "1850" },
                    { 888, "Grimminge GERAARDSBERGEN", "9506" },
                    { 889, "Grivegn�e LI�GE", "4030" },
                    { 890, "GROBBENDONK GROBBENDONK", "2280" },
                    { 891, "Groot-Bijgaarden DILBEEK", "1702" },
                    { 892, "Groot-Gelmen SINT-TRUIDEN", "3800" },
                    { 904, "Guirsch ARLON", "6704" },
                    { 893, "Groot-Loon BORGLOON", "3840" },
                    { 895, "Grosage CHI�VRES", "7950" },
                    { 896, "Grote-Brogel PEER", "3990" },
                    { 897, "Grote-Spouwen BILZEN", "3740" },
                    { 898, "Grotenberge ZOTTEGEM", "9620" },
                    { 899, "Gruitrode OUDSBERGEN", "3670" },
                    { 900, "Grune NASSOGNE", "6952" },
                    { 901, "Grupont TELLIN", "6927" },
                    { 902, "Guignies BRUNEHAUT", "7620" },
                    { 894, "Gros-Fays BI�VRE", "5555" },
                    { 926, "HALLE HALLE", "1500" },
                    { 927, "Halle ZOERSEL", "2980" },
                    { 928, "Halle-Booienhoven ZOUTLEEUW", "3440" },
                    { 952, "Hantes-Wih�ries ERQUELINNES", "6560" },
                    { 953, "Hanzinelle FLORENNES", "5621" },
                    { 954, "Hanzinne FLORENNES", "5621" },
                    { 955, "Harchies BERNISSART", "7321" },
                    { 956, "HARELBEKE HARELBEKE", "8530" },
                    { 957, "Haren BRUSSEL", "1130" },
                    { 958, "Haren TONGEREN", "3700" },
                    { 959, "Haren BORGLOON", "3840" },
                    { 951, "Hansbeke DEINZE", "9850" },
                    { 960, "Hargimont MARCHE-EN-FAMENNE", "6900" },
                    { 962, "Harnoncourt ROUVROY", "6767" },
                    { 963, "Harre MANHAY", "6960" },
                    { 964, "Harsin NASSOGNE", "6950" },
                    { 965, "Harveng MONS", "7022" }
                });

            migrationBuilder.InsertData(
                table: "ZipCode",
                columns: new[] { "Id", "City", "Code" },
                values: new object[,]
                {
                    { 966, "Harz� AYWAILLE", "4920" },
                    { 967, "HASSELT HASSELT", "3500" },
                    { 968, "HASTI�RE HASTI�RE", "5540" },
                    { 969, "Hasti�re-Lavaux HASTI�RE", "5540" },
                    { 961, "Harmignies MONS", "7022" },
                    { 950, "Hanret EGHEZ�E", "5310" },
                    { 949, "HANNUT HANNUT", "4280" },
                    { 948, "Hann�che BURDINNE", "4210" },
                    { 929, "Halleux LA ROCHE-EN-ARDENNE", "6986" },
                    { 930, "Halma WELLIN", "6922" },
                    { 931, "Halmaal SINT-TRUIDEN", "3800" },
                    { 932, "Haltinne GESVES", "5340" },
                    { 933, "HAM HAM", "3945" },
                    { 934, "HAM-SUR-HEURE HAM-SUR-HEURE", "6120" },
                    { 935, "Ham-Sur-Sambre JEMEPPE-SUR-SAMBRE", "5190" },
                    { 936, "Hamipr� NEUFCH�TEAU", "6840" },
                    { 937, "Hamme MERCHTEM", "1785" },
                    { 938, "HAMME HAMME", "9220" },
                    { 939, "Hamme-Mille BEAUVECHAIN", "1320" },
                    { 940, "HAMOIR HAMOIR", "4180" },
                    { 941, "HAMOIS HAMOIS", "5360" },
                    { 942, "Hamont HAMONT-ACHEL", "3930" },
                    { 943, "HAMONT-ACHEL HAMONT-ACHEL", "3930" },
                    { 944, "Hampteau HOTTON", "6990" },
                    { 945, "Han-Sur-Lesse ROCHEFORT", "5580" },
                    { 946, "Handzame KORTEMARK", "8610" },
                    { 947, "Haneffe DONCEEL", "4357" },
                    { 883, "Graux METTET", "5640" },
                    { 2825, "ZWIJNDRECHT ZWIJNDRECHT", "2070" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2451);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2454);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2470);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2489);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2497);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2519);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2521);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2534);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2535);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2536);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2538);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2541);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2562);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2563);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2565);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2566);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2567);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2568);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2569);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2570);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2571);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2572);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2573);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2574);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2575);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2576);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2577);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2578);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2579);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2580);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2581);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2582);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2583);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2584);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2585);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2586);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2587);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2588);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2589);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2590);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2591);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2592);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2593);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2594);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2595);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2596);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2597);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2598);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2599);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2601);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2602);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2603);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2604);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2606);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2607);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2608);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2609);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2610);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2611);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2612);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2613);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2614);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2615);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2616);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2617);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2618);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2619);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2620);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2621);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2622);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2625);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2626);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2627);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2628);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2629);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2631);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2632);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2633);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2634);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2635);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2636);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2637);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2638);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2639);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2641);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2643);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2644);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2645);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2646);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2647);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2648);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2649);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2650);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2651);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2652);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2653);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2654);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2655);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2656);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2657);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2658);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2659);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2661);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2662);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2663);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2664);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2665);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2666);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2667);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2668);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2669);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2670);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2671);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2672);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2673);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2674);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2675);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2676);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2677);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2678);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2679);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2680);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2682);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2683);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2685);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2688);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2689);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2690);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2691);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2692);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2694);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2697);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2698);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2699);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2706);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2707);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2708);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2714);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2715);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2716);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2717);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2718);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2719);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2720);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2721);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2722);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2723);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2724);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2725);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2726);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2727);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2728);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2729);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2730);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2731);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2732);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2733);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2734);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2735);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2736);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2737);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2738);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2739);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2740);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2741);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2742);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2743);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2744);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2745);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2746);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2747);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2748);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2749);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2750);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2751);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2752);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2753);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2754);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2755);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2756);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2757);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2758);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2759);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2761);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2763);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2764);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2765);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2766);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2767);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2768);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2769);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2770);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2771);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2772);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2773);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2774);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2775);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2776);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2777);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2778);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2779);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2780);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2781);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2782);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2783);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2784);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2785);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2786);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2787);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2788);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2789);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2790);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2791);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2792);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2793);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2795);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2796);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2797);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2798);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2799);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2801);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2802);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2803);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2806);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2807);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2808);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2809);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2810);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2811);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2812);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2813);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2814);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2815);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2816);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2817);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2818);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2819);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2820);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2821);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2822);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2823);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2824);

            migrationBuilder.DeleteData(
                table: "ZipCode",
                keyColumn: "Id",
                keyValue: 2825);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstSigns",
                table: "Subjects",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 978, DateTimeKind.Local).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 986, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CoronaTest",
                table: "Subjects",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 30, 17, 38, 46, 974, DateTimeKind.Local).AddTicks(8825),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 7, 30, 18, 3, 47, 983, DateTimeKind.Local).AddTicks(3109));
        }
    }
}
