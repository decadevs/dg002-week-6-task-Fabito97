using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGNet002_Week6_Task
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }

        public static List<Item> items = new List<Item>()
        {
            new Item {ItemId = 1, ItemDescription = "Bag"},
            new Item {ItemId = 2, ItemDescription = "Pen"},
            new Item {ItemId = 3, ItemDescription = "Bag"},
            new Item {ItemId = 4, ItemDescription = "Shoe"},
            new Item {ItemId = 5, ItemDescription = "Pin"},
        };







        //static List<string> states = new List<string>()
        /* "Abia(Umuahia)", "Adamawa(Yola)", "Akwa Ibom State(Uyo)", "Anambra(Awka)", "Bauchi(Bauchi)", "Bayelsa(Yenagoa)",
        "Benue(Makurdi)", "Borno(Maiduguri)","Cross River(Calabar)", "Delta(Asaba)", "Ebonyi(Abakiliki)", "Edo(Benin)",
        "Ekiti(Ekity)", "Enugu(Enugu)", "Gombe(Gombe)", "Imo(Owerri)", "Jigawa(Dutse)", "Kaduna(Kaduna)", "Kano(Kano)",
        "Katsina(Katsina)", "Kebbi(Birnin Kebbi)", "Kogi(Lokoja)", "Kwara(Ilorin)", "Lagos(Ikeja)", "Nasarawa(Lafia)",
        "Niger(Minna)", "Ogun(Abeokuata)", "Ondo(Akure)", "Osun(Oshogbo)", "Oyo(Ibadan)", "Plateau(Jos)", "Rivers(Port Harcourt",
        "Sokoto(Sokoto)", "Taraba(Jalingo)", "Yobe(Damaturu)", "Zamfara(Gusau)",*/

    }
}
