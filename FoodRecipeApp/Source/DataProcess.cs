using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp.Source
{
    public class DataProcess
    {
        public static List<Foods> lstFood = new List<Foods>
        {
            new Foods {Id = 1, Name = "bò viên", urlImage = @"Images\bovien.jpg", isLike = false },
            new Foods {Id = 2, Name = "gỏi nha đam", urlImage = @"Images\goinhadam.jpg", isLike = true },
            new Foods {Id = 3, Name = "sườn xào chua ngọt", urlImage = @"Images\Suonxaochuangot.jpg", isLike = true },
            new Foods {Id = 4, Name = "kem sữa chua dưa hấu", urlImage= @"Images\kemsuachuaduahau.jpg", isLike = true},
            new Foods {Id = 5, Name = "mì xào gà", urlImage= @"Images\mixaoga.jpg", isLike = false},
            new Foods {Id = 6, Name = "tôm sú nướng muối ớt", urlImage= @"Images\tomxunuongmuoiot.jpg", isLike= false},
            new Foods {Id = 7, Name = "mứt sung", urlImage = @"Images\mutsung.jpg", isLike = false},
            new Foods {Id = 8, Name = "muối hành chua", urlImage = @"Images\muoihanhchua.jpg", isLike = true},
            new Foods {Id = 9, Name = "gà kho gừng", urlImage = @"Images\gakhogung.jpg", isLike = false},
            new Foods {Id = 10, Name = "thịt kho tiêu", urlImage = @"Images\thitkhotieu.jpg", isLike = true}

        };
        public static List<Recipe> lstRecipes = new List<Recipe>
        {
            new Recipe{IdFood = 1, urlVideo = $"https://www.youtube.com/watch?v=-Z47zuXlUOw", lstStep = new List<Step>{
                new Step{ urlImage = "", Description = "- Chuẩn bị nguyên liệu: 1 kg thịt bò xay sẵn, 5 muỗng nước mắm, 6 muỗng nước, 2 muỗng tinh bột khoai lang tây hoặc bột năng, 1 muỗng cà phê đường, Bột ngọt, hạt tiêu, Bột nở\n- Dầu mè, Gừng, muối"},
                new Step{ urlImage = "", Description = "- Cho hỗn hợp nước mắm, đường, tiêu, bột ngọt, dầu mè vào trộn đều. Sau đó cho thịt vào hỗn hợp, trộn đều, đeo găng tay trộn cho thịt thấm gia vị."},
                new Step{ urlImage = "", Description = "- Tiếp tục trộn bột nở, bột khoai tây với nước, sau đó đổ vào hỗn hợp vừa trộn ở trên, rồi tiếp tục trộn thật đều cho đến khi thịt mịn."},
                new Step{ urlImage = "", Description = "- Cho thịt vào bịch nylon, dàn trải ra cho mỏng và cất vào tủ đá khoảng 2 tiếng. Lúc này thịt lạnh, nhưng không đông cứng, lấy thịt ra đem ra xay nhuyễn một lần nữa."},
                new Step{ urlImage = "", Description = "- Sau đó cho thịt lại vào túi nylon rồi cho vào ngăn đá để thêm gần 2 tiếng, lấy thịt ra có thể dùng dao cắt nhỏ hoặc bẻ ra rồi cho vào máy quết."},
                new Step{ urlImage = "", Description = "- Quết từ từ cho đến khi dính đều khoảng 3 phút. Nếu không có máy các bạn có thể nhồi bằng tay, hoặc bỏ vào máy xay, xay nhè nhẹ cho thịt mịn."},
                new Step{ urlImage = @"Images\bovien-step7.jpg", Description = "- Lấy một tô nước lạnh lớn. Đeo găng tay, dùng tay phải múc một muỗng thịt cho vào tay trái và bóp thịt cho trồi lên phần ngón trỏ và ngón cái, dùng muỗng gạt vào tô nước lạnh. Cứ tiếp tục cho đến khi hết phần thịt."},
                new Step{ urlImage = @"Images\bovien-step8.jpg", Description = "- Cho một nồi nước lên bếp đun, cho thêm một chút muối và gừng cho nước đậm đà. Khi nước sôi bạn thả các viên bò vào luộc khoảng 10 phút là được. Sau đó, vớt bò viên ra một tô nước lạnh khác, làm như vậy sẽ giúp viên bò trắng, đẹp mắt mà không bị thâm."},
                new Step{ urlImage = "", Description = "- Vớt bò viên ra để ráo nước, bảo quản trong tủ lạnh để ăn dần."}
                }
            },
            new Recipe{IdFood = 2, urlVideo = $"https://www.youtube.com/watch?v=_VH6HDprqYU", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\goinhadam-1.jpg", Description = "- Chuẩn bị nguyên liệu: Nha đam: 200, Tôm đất: 100g, Cà rốt: 1/3 củ, Dưa chuột: 1/2 quả, Rau húng bạc hà: 1 mớ, Các nguyên liệu khác: Hành phi, vừng rang, ớt sừng băm, nước mắm, đường, muối, giấm gạo lên men, hạt nêm."},
                new Step{ urlImage = @"Images\goinhadam-2.jpg", Description = "- Nha đam bào vỏ, ngâm nước, chần sơ qua nước sôi có chút muối rồi ngâm vào nước đá cho nguội, sau đó vớt ra để ráo rồi cắt sợi. Tôm luộc chín với 1/2 muỗng hạt nêm, vớt tôm ra cho vào tô nước đá, bóc vỏ, chừa lại đuôi tôm. Cà rốt bào vỏ, cắt sợi. Dưa chuột bỏ ruột, cắt sợi. Rau húng bạc hà rửa sạch, cắt nhuyễn."},
                new Step{ urlImage = @"Images\goinhadam-3.jpg", Description = "- Pha nước trộn gỏi: Trộn đều 2 muỗng giấm gạo lên men với 2 muỗng đường, 2 muỗng nước mắm và 1 muỗng ớt băm."},
                new Step{ urlImage = @"Images\goinhadam-4.jpg", Description = "- Cho nha đam, dưa chuột, cà rốt, tôm và rau húng bạc hà vào bát, trộn đều với nước trộn gỏi. Cuối cùng, bạn cho gỏi nha đam ra dĩa, rắc một chút vừng và hành phi lên trên."}
                }
            },
            new Recipe{IdFood = 3, urlVideo = $"https://www.youtube.com/watch?v=IaIOvYskdss", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\Suonxaochuangot-1.jpg", Description = "Chuẩn bị nguyên liệu: 500g sườn, 15ml rượu gia vị (hoặc rượu gạo), 20ml nước tương, 45ml giấm, 45g đường, 3g muối, 3g vừng."},
                new Step{ urlImage = @"Images\Suonxaochuangot-2.jpg", Description = "- Đun sôi nước, thả sườn vào nấu trong 30 phút thì vớt sườn ra, giữ lại nước dùng. Hòa rượu gia vị , nước tương và 30ml giấm, ướp sườn trong 20 phút."},
                new Step{ urlImage = @"Images\Suonxaochuangot-3.jpg", Description = "- Chiên sơ sườn đã ướp tới khi có màu vàng nhạt.  Cho sườn và nước dùng vào nồi, thêm đường và đun cho tới khi cô lại còn khoảng nửa bát nước. Cho muối vào nồi. Cho nhỏ lửa và đun thêm 10 phút, thêm 15ml giấm hoặc điều chỉnh độ chua ngọt theo khẩu vị."},
                new Step{ urlImage = @"Images\Suonxaochuangot-4.jpg", Description = "- Bày ra đĩa, rắc vừng lên cho món ăn thêm hấp dẫn."}
                }
            },
            new Recipe{IdFood = 4, urlVideo = $"https://www.youtube.com/watch?v=4LlS0G7WuEQ", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\kemsuachuaduahau-1.jpg", Description = "- Chuẩn bị nguyên liệu: 300g dưa hấu, 225ml sữa chua, 75g đường, mật ong 30ml, nước cốt chanh 25ml, rượu vodka ( hoặc rượu trắng đều được)"},
                new Step{ urlImage = @"Images\kemsuachuaduahau-2.jpg", Description = "- Dưa hấu rửa sạch, gọt vỏ, bỏ hạt, cắt thành từng miếng vừa."},
                new Step{ urlImage = @"Images\kemsuachuaduahau-3.jpg", Description = "- Cho dưa hấu vào máy xay sinh tố xay nhuyễn, sau đó lược qua rây để loại bỏ những hạt dưa còn sót lại."},
                new Step{ urlImage = @"Images\kemsuachuaduahau-4.jpg", Description = "- Đổ hỗn hợp trên vào máy làm kem và đặt thời gian khoảng 30 phút. Nếu bạn không có máy làm kem thì hãy đổ hỗn hợp ra hộp nhựa, đậy kín nắp hoặc túi đựng thực phẩm và để trong ngăn đá tủ lạnh. Tiếp đến, cứ khoảng 1 tiếng là bạn lấy ra dùng muỗng trộn đều một lần. Thực hiện 4 lần như vậy là bạn đã có được một món kem sữa chua dưa hấu cực kỳ hấp dẫn rồi đấy!"}
                }
            },
            new Recipe{IdFood = 5, urlVideo = $"https://www.youtube.com/watch?v=VtfQDUPAAhM", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\mixaoga-1.jpg", Description = "- Chuẩn bị nguyên liệu: 2 gói mì trứng (khoảng 700g), 3 cây cần tây, Nửa củ cà rốt, Hành lá, Thịt đùi hoặc ức gà, Tỏi băm, Nửa cái bắp cải nhỏ, Dầu hào, nước tương, 2 quả ớt."},
                new Step{ urlImage = @"Images\mixaoga-2.jpg", Description = "- Sơ chế nguyên liệu: Cần tây rửa sạch, thái thành khúc ngắn. Cà rốt thái sợi. Bắp cải, hành lá thái nhỏ. Thịt gà đùi luộc chín rồi cắt thành khúc nhỏ vừa ăn. Luộc mì rồi để cho ráo nước."},
                new Step{ urlImage = "", Description = "- Bắp chảo lên bếp, cho dầu ăn vào rồi cho tỏi băm vào, phi đều. Cho bắp cải, cần tây, cà rốt đã được thái nhỏ vào chảo, đảo đều. Sau đó cho dầu hào, nước tương đảo đều tay, khi thấy mì hơi săn, cho thịt gà đã thái vào chảo. Cho mì đã được ráo nước vào hỗn hợp, đảo đều trên bếp. Sau đó cho hành hoa, ớt đập dập vào nữa là hoàn thành."}
                }
            },
            new Recipe{IdFood = 6, urlVideo = $"https://www.youtube.com/watch?v=yaiHlWtjGiM", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\tomxunuongmuoiot.jpg", Description = "- Chuẩn bị nguyên liệu: 400g tôm sú tươi, 1 quả ớt sừng, 3 quả ớt hiểm, 2 tép tỏi, bằm nhuyễn, 1 miếng chanh, vắt lấy nước, 1 thìa cà phê hạt nêm, 1 thìa canh muối hột, 1 thìa cà phê đường cát trắng, 1/4 thìa cà phê tiêu xay, 2 thìa canh tương ớt, 2 thìa canh dầu ăn, Rau xà lách, cà chua, dưa leo, Chuẩn bị que xiên và bếp than hoặc lò nướng."},
                new Step{ urlImage = "", Description = "- Tôm sú mua về có thể cắt bớt râu, rửa sạch và để ráo nước. Làm muối ớt, tỏi bóc sạch vỏ rồi xay nhuyễn và ớt rồi trộn đều với hạt nêm, muối hột, đường cát trắng, tương ớt, tiêu xay, dầu ăn, chanh."},
                new Step{ urlImage = "", Description = "- Ướp tôm với hỗn hợp muối ớt khoảng 30 phút cho thấm đều gia vị. Tiếp theo dùng que xiên, xiên từ đầu đến đuôi tôm, làm cho hết nguyên liệu còn lại."},
                new Step{ urlImage = "", Description = "- Đặt các xiên tôm lên vỉ nướng trên bếp than, nướng chín đỏ đều hai mặt là tôm chín. Khi nướng phết đều hỗn hợp nước ướp lên mình tôm."},
                new Step{ urlImage = "", Description = "- Đặt các xiên tôm lên vỉ nướng trên bếp than, nướng chín đỏ đều hai mặt là tôm chín. Khi nướng phết đều hỗn hợp nước ướp lên mình tôm."}
                }
            },
            new Recipe{IdFood = 7, urlVideo = $"https://www.youtube.com/watch?v=FIX0JybEIZg", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\mutsung-1.jpg", Description = "- Chuẩn bị nguyên liệu: 1kg sung chín, 1 trái quýt, 400g đường, 30g muối hột"},
                new Step{ urlImage = @"Images\mutsung-2.jpg", Description = "- Chọn sung vừa chín tới. Sung có mùi thơm nhẹ, vị hơi ngọt.Sung Cắt bỏ cuống và chẻ đôi rồi ngâm vào nước muối loãng 15 phút. Rửa sạch, vớt ra cho ráo."},
                new Step{ urlImage = "", Description = "- Rắc đường vào sung, trộn đều để 6-8 giờ cho ngấm và ra nước đường.Quýt vắt lấy nước. Lấy 1/4 vỏ quýt xắt sợi nhỏ."},
                new Step{ urlImage = "", Description = "- Chắt nước đường đó ra rim trên lửa lớn cho sôi thì cho nước và vỏ quýt vào, cho sung vào rim lửa vừa."},
                new Step{ urlImage = "", Description = "- Khi thấy nước đường gần cạn thì rim lửa nhỏ. Lâu lâu đảo cho sung thấm nước đường, rim như vậy trong 20-30 phút cho đến khi đường sánh quyện vào mứt là bạn có thể tắt bếp.Bảo quản mứt trong hợp kín cất trong tủ lạnh. Mứt sung dẻo, bùi, thơm nhẹ của quýt, ngọt nhẹ."}
                }
            },
            new Recipe{IdFood = 8, urlVideo = $"https://www.youtube.com/watch?v=Q0PeZXQ79zg", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\muoihanhchua-1.jpg", Description = "- Chuẩn bị nguyên liệu: 1 kg hành trắng hoặc tím, Nước vo gạo, 1-2 quả ớt sừng nếu thích ăn cay, Muối, 2 bát nước sôi để nguội, 1 bát đường, 1 bát giấm gạo, 1 củ gừng, Hũ thủy tinh sạch muối hành."},
                new Step{ urlImage = @"Images\muoihanhchua-2.jpg", Description = "- Hành mua về bóc sạch lớp vỏ bên ngoài, cắt bỏ gốc và phần đầu hành, rửa sơ qua cho sạch lớp bụi bẩn."},
                new Step{ urlImage = @"Images\muoihanhchua-3.jpg", Description = "- Sau đó bạn cho hành vào tô hoặc thau rồi đổ nước vo gạo ngập hành và ngâm 6-8 tiếng hoặc qua đêm."},
                new Step{ urlImage = @"Images\muoihanhchua-4.jpg", Description = "- Sau 6-8 tiếng thì vớt hành ra rửa lại thật sạch, cho hành vào tô và thêm vài thìa muối, xóc thật đều rồi để thêm 3-4 tiếng cho hành ra bớt chất hăng. Rửa lại hành bằng nước đun sôi để nguội cho bớt mặn, đổ ra để ráo nước."},
                new Step{ urlImage = @"Images\muoihanhchua-5.jpg", Description = "- Tiếp theo bạn pha hỗn hợp nước muối hành như sau: Cho giấm, đường, nước, 2 thìa cà phê muối vào cùng và khuấy đều cho muối đường tan hết. Ớt sừng và gừng thái lát mỏng."},
                new Step{ urlImage = @"Images\muoihanhchua-6.jpg", Description = "- Xếp hành vào hũ thủy tinh hoặc bằng sứ, xen lẫn ớt và gừng sau đó đổ nước giấm muối vào ngập hành, dùng vỉ hoặc dụng cụ để chèn lên trên đảm bảo cho hành luôn ngập trong nước muối. Đậy kín khoảng 3-4 ngày sẽ chua giòn, tùy theo thời tiết mà hành sẽ nhanh chín hơn. Khi hành đã chín vừa ăn bạn cất trong tủ lạnh ăn dần."}
                }
            },
            new Recipe{IdFood = 9, urlVideo = $"https://www.youtube.com/watch?v=2qML8Lz3OHM", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\gakhogung-1.jpg", Description = "- Chuẩn bị nguyên liệu: Gà: 1/2 con (hoặc bạn có thể chọn phần thịt đùi/ức/cánh tùy thích), Gừng: 50 gram, Hành tím: 2 củ, Dầu ăn: 1 muỗng canh, Đường: 1 muỗng canh, Nước mắm: 1 muỗng canh, Bột ngọt: 1/6 muỗng cà phê, Tiêu: 1/4 muỗng cà phê, Hành lá: lấy phần gốc trắng, 10 gram"},
                new Step{ urlImage = @"Images\gakhogung-2.jpg", Description = "- Sơ chế nguyên liệu: Rửa sạch ra, trụng sơ với nước sôi, vớt ra để ráo. Chặt gà thành những miếng vừa ăn."},
                new Step{ urlImage = "", Description = "- Ướp thịt gà với nước mắm, đường, bột ngọt, ít dầu ăn, hành tím đập dập. Đặt thịt gà vừa ướp vào ngăn mát tủmon lạnh khoảng 30 phút."},
                new Step{ urlImage = "", Description = "- Làm nóng dầu, cho phần đường còn lại vào chảo, làm nước màu. Khi đường vừa chuyển sang màu cánh gián thì trút thịt gà đã ướp vào, đảo đều để thịt gà được ướp đều nước màu."},
                new Step{ urlImage = "", Description = "- Khi thịt gà săn lại, vặn nhỏ lửa. Tiếp tục đảo đều khoảng 2 phút rồi cho gừng vào, đảo tiếp đến khi thịt gà chín, săn lại. Cho thịt gà xào gừng ra đĩa. Trang trí gốc hành trắng, ít tiêu lên trên. Món này dùng với cơm nóng."}
                }
            },
            new Recipe{IdFood = 10, urlVideo = $"https://www.youtube.com/watch?v=lg56Z8zOzeg", lstStep = new List<Step>{
                new Step{ urlImage = @"Images\thitkhotieu-1.jpg", Description = "- Chuẩn bị nguyên liệu: 300g thịt nạc (tùy theo sở thích, các bạn có thể chọn thịt nạc ở chỗ nào cũng được), Hành tím, tỏi, Muối, tiêu, đường, bột ngọt, nước mắm"},
                new Step{ urlImage = @"Images\thitkhotieu-2.jpg", Description = "- Sơ chế nguyên liệu: Thịt nạc các bạn ngâm trong nước muối khoảng 15 phút rồi rửa sạch. Sau đó lau khô và cắt thành từng miếng vừa ăn. Hành tím và tỏi các bạn băm nhỏ. Các bạn có thể chọn mua nước màu ở bên ngoài hoặc tự mình thắng nước màu tại nhà."},
                new Step{ urlImage = "", Description = "- Các bạn cho thịt vào kho đến khi săn lại thì bắt đầu nêm gia vị. Các bạn nêm vào thịt ½ muỗng cà phê muối, 2 muỗng canh nước mắm, 2 muỗng cà phê bột ngọt, đảo đều."},
                new Step{ urlImage = "", Description = "- Tùy theo việc bạn có thích ăn thịt nhiều nước hay không, mà chọn đậy nắp lại hay không. Nếu các bạn muốn ăn nước thịt nhiều, thì hãy đậy nắp lại, vặn lửa vừa. Ngược lại muốn ăn khô thì mở nắp và vặn lửa to bạn nhé."},
                new Step{ urlImage = "", Description = "- Cuối cùng khi thịt đã chín các bạn múc ra và rắc tiêu lên. Các bạn cũng có thể kho thịt cùng với tiêu, nhưng rắc tiêu lên ngay sau khi thịt vừa chín sẽ làm dậy lên hương thơm đặc trưng của món ăn hơn."}
                }
            }
        };
    }
}
