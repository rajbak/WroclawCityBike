﻿using System.Collections.Generic;
using WroclawCityBike.Models;

namespace WroclawCityBike.Services
{
    public class MockDataService : IDataService
    {
        public IList<BikeStation> GetBikeStations()
        {
            var stations = new List<BikeStation>();

            stations.Add(new BikeStation(51.13207714749649, 17.06550121307373, "Pl. Kromera"));
            stations.Add(new BikeStation(51.12811145398997, 17.05474019050598, "Jedności Narodowej - Wyszyńskiego"));
            stations.Add(new BikeStation(51.12462351680015, 17.045599222183228, "Jedności Narodowej - Nowowiejska"));
            stations.Add(new BikeStation(51.12454271204484, 17.034999132156372, "Dworzec Nadodrze"));
            stations.Add(new BikeStation(51.12557296208677, 17.050459384918213, "Żeromskiego - Daszyńskiego"));
            stations.Add(new BikeStation(51.12288618340934, 17.03056812286377, "Plac Staszica"));
            stations.Add(new BikeStation(51.121323874330685, 17.036458253860474, "Bajana - Szybowcowa"));
            stations.Add(new BikeStation(51.121256532234305, 17.043163776397705, "Jedności Narodowej - Oleśnicka"));
            stations.Add(new BikeStation(51.122387866424724, 17.047605514526364, "Żeromskiego - Kluczborska"));
            stations.Add(new BikeStation(51.1222834885376, 17.05226182937622, "Nowowiejska - Wyszyńskiego"));
            stations.Add(new BikeStation(51.119431524045254, 17.05151081085205, "Wyszyńskiego - Prusa"));
            stations.Add(new BikeStation(51.11920928565168, 17.05654263496399, "Nowowiejska - Prusa"));
            stations.Add(new BikeStation(51.11743807478881, 17.041382789611816, "Plac Bema"));
            stations.Add(new BikeStation(51.11698010808053, 17.033389806747437, "Drobnera - Dubois"));
            stations.Add(new BikeStation(51.116838676267925, 17.05156981945038, "Sienkiewicza - Wyszyńskiego"));
            stations.Add(new BikeStation(51.11568363359365, 17.060614228248596, "Sienkiewicza - Piastowska"));
            stations.Add(new BikeStation(51.113844934670325, 17.034462690353394, "Plac Uniwersytecki"));
            stations.Add(new BikeStation(51.11287840974499, 17.039633989334103, "Hala Targowa"));
            stations.Add(new BikeStation(51.11390891992754, 17.067153453826904, "Kredka i Ołówek"));
            stations.Add(new BikeStation(51.111187784441235, 17.03857183456421, "Plac Nowy Targ"));
            stations.Add(new BikeStation(51.1102515151332, 17.03505277633667, "Wita Stwosza - Szewska"));
            stations.Add(new BikeStation(51.10971938239645, 17.0302677154541, "Rynek"));
            stations.Add(new BikeStation(51.11143026836378, 17.021266222000122, "Jana Pawła II"));
            stations.Add(new BikeStation(51.11413791906944, 17.0137345790863, "Inowrocławska - Urząd Skarbowy"));
            stations.Add(new BikeStation(51.11760644376091, 17.007222175598145, "Zachodnia - Poznańska"));
            stations.Add(new BikeStation(51.11346438894182, 17.00635313987732, "Plac Strzegomski"));
            stations.Add(new BikeStation(51.11533677840705, 16.998703479766846, "Dworzec Mikołajów"));
            stations.Add(new BikeStation(51.12527668338291, 16.98439121246338, "Legnicka - Wejherowska"));
            stations.Add(new BikeStation(51.111955645831195, 16.960535645484924, "Strzegomska - Gubińska"));
            stations.Add(new BikeStation(51.11010332688538, 17.047863006591797, "Muzeum Narodowe"));
            stations.Add(new BikeStation(51.11094529924635, 17.052347660064697, "Uniwersytet Wrocławski - Joliot Curie"));
            stations.Add(new BikeStation(51.110362656007275, 17.055496573448178, "Plac Grunwaldzki - Polaka"));
            stations.Add(new BikeStation(51.112171183577146, 17.06024408340454, "Rondo Reagana"));
            stations.Add(new BikeStation(51.108048849946385, 17.06479847431183, "Smoluchowskiego - Łukaszewicza"));
            stations.Add(new BikeStation(51.10723376985792, 17.061327695846558, "Politechnika Wrocławska - Gmach Główny"));
            stations.Add(new BikeStation(51.11400321382931, 17.103824615478516, "Mickiewicza - pętla tramwajowa"));
            stations.Add(new BikeStation(51.1039396220822, 17.084147930145264, "Teki"));
            stations.Add(new BikeStation(51.1019589785129, 17.10146427154541, "Olszewskiego - Spółdzielcza"));
            stations.Add(new BikeStation(51.104384244689136, 17.02254295349121, "Plac Legionów"));
            stations.Add(new BikeStation(51.104121513665575, 17.031673192977905, "Świdnicka - Chrobry"));
            stations.Add(new BikeStation(51.10462002766963, 17.037112712860107, "Teatralna - Piotra Skargi"));
            stations.Add(new BikeStation(51.10443813804785, 17.048335075378418, "Traugutta - Pułaskiego"));
            stations.Add(new BikeStation(51.10185118595181, 17.0137882232666, "Zaporoska - Grabiszyńska"));
            stations.Add(new BikeStation(51.10123811098068, 17.02876567840576, "Świdnicka - Piłsudskiego"));
            stations.Add(new BikeStation(51.07333122768277, 16.995055675506592, "Skarbowców - Wietrzna"));
            stations.Add(new BikeStation(51.09965485778756, 17.035846710205078, "Dworzec kolejowy - północ"));
            stations.Add(new BikeStation(51.10022753009522, 17.04504132270813, "Kościuszki - Pułaskiego"));
            stations.Add(new BikeStation(51.09891037318256, 17.051634192466732, "Kościuszki - Komuny Paryskiej / Zgodna"));
            stations.Add(new BikeStation(51.09699352280998, 17.0562744140625, "Traugutta - Kościuszki"));
            stations.Add(new BikeStation(51.09695646516561, 17.03801929950714, "Dworzec kolejowy - południe"));
            stations.Add(new BikeStation(51.10097536207561, 17.0082950592041, "Pereca - Grabiszyńska"));
            stations.Add(new BikeStation(51.099264089082496, 17.000784873962402, "Grabiszyńska - Stalowa"));
            stations.Add(new BikeStation(51.09804123119159, 17.00680375099182, "Żelazna - Pereca"));
            stations.Add(new BikeStation(51.09722260577026, 17.01408863067627, "Zaporoska - Gajowicka"));
            stations.Add(new BikeStation(51.094790225798505, 16.980035305023193, "FAT - Grabiszyńska - Hallera"));
            stations.Add(new BikeStation(51.091191955420186, 16.98563575744629, "Hallera - Odkrywców"));
            stations.Add(new BikeStation(51.09342911524615, 17.002780437469482, "Krucza - Mielecka"));
            stations.Add(new BikeStation(51.09544381415203, 17.007962465286255, "Grochowa - Jemiołowa"));
            stations.Add(new BikeStation(51.09425117690591, 17.01447486877441, "Zaporoska - Wielka"));
            stations.Add(new BikeStation(51.07496256893404, 17.006921768188477, "Park Południowy - Powstańców Śląskich"));
            stations.Add(new BikeStation(51.094668940345535, 17.026888132095333, "Arena - Komandorska"));
            stations.Add(new BikeStation(51.089264676748826, 17.00162172317505, "Centrum Handlowe Borek"));
            stations.Add(new BikeStation(51.08992845137241, 17.023476362228394, "Komandorska - Kamienna"));
            stations.Add(new BikeStation(51.089756612155334, 17.028229236602783, "Ślężna - Kamienna"));
            stations.Add(new BikeStation(51.09156257672623, 17.040224075317383, "Gliniana - Gajowa"));
            stations.Add(new BikeStation(51.08774166546555, 17.040288448333737, "Kamienna - Gajowa"));
            stations.Add(new BikeStation(51.08658926519162, 17.01230764389038, "Powstańców Śląskich - Hallera"));
            stations.Add(new BikeStation(51.08346213967434, 17.0352566242218, "Armii Krajowej - Borowska"));
            stations.Add(new BikeStation(51.08016629798973, 17.04749822616577, "Krynicka"));
            stations.Add(new BikeStation(51.08013933717133, 16.99460506439209, "Racławicka - Rymarska"));
            stations.Add(new BikeStation(51.094520702137686, 17.020998001098633, "Sky Tower"));
            stations.Add(new BikeStation(51.099264089082496, 17.02756404876709, "Arkady"));
            stations.Add(new BikeStation(51.12887566759688, 17.04499840736389, "Promenady Business Park"));
            stations.Add(new BikeStation(51.048031338767885, 16.9643497467041, "Aleja Bielany"));


            return stations;
        }
    }
}
