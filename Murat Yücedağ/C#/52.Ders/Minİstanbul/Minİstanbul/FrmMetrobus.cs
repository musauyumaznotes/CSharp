using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minİstanbul
{
    public partial class FrmMetrobus : Form
    {
        public FrmMetrobus()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "34 Avcılar-Zincirlikuyu")
            {
                textBox1.Text = "Avcılar - Denizköşkler - İETT Kampı- Küçükçekmece- Cennet Mah.-Yeşilova - Sefaköy- Yenibosna - Şirinevler- İncirli - Zeytinburnu Metro-Merter- Cevizlibağ- Topkapı- Maltepe- Adnan Menderes Bulvarı- Edirnekapı- Ayvansaray-Halıcıoğlu- Okmeydanı- Perpa- SSK Okmeydanı Hastahanesi- Çağlayan- Mecidiyeköy-Zincirlikuyu";
            }
            if (comboBox1.Text== "34A Cevizlibağ-Söğütlüçeşme")
            {
                textBox1.Text = "1. Cevizlibağ 2.Topkapı 3.Bayrampaşa – Maltepe 4.Adnan Menderes 5.Edirnekapı 6.Ayvansaray 7.Halıcıoğlu 8.Okmeydanı 9.Darülaceze – Perpa 10.Okmeydanı Hastane 11.Çağlayan 12.Mecidiyeköy 13.Zincirlikuyu 14. 15 Temmuz Şehitler Köprüsü 15.Burhaniye 16.Altunizade 17.Acıbadem 18.Uzunçayır 19.Fikirtepe 20.Söğütlüçeşme";
            }
            if (comboBox1.Text == "34AS Avcılar-Söğütlüçeşme")
            {
                textBox1.Text = "1. Avcılar Merkez Üniversite Kampüs 2.Şükrübey 3.İBB Sosyal Tesisler 4.Küçükçekmece 5.Cennet 6.Florya 7.Beşyol 8.Sefaköy 9.Yenibosna 10.Şirinevler 11.Bahçelievler 12.İncirli 13.Zeytinburnu 14.Merter 15.Cevizlibağ 16.Topkapı 17.Bayrampaşa – Maltepe 18.Adnan Menderes 19.Edirnekapı 20.Ayvansaray 21.Halıcıoğlu 22.Okmeydanı 23.Darülaceze – Perpa 24.Okmeydanı Hastane 25.Çağlayan 26.Mecidiyeköy 27.Zincirlikuyu 28. 15 Temmuz Şehitler Köprüsü 29.Burhaniye 30.Altunizade 31.Acıbadem 32.Uzunçayır 33.Fikirtepe 34.Söğütlüçeşme";
            }
            if (comboBox1.Text == "34BZ Beylikdüzü-Zincirlikuyu")
            {
                textBox1.Text = "1. Beylikdüzü Son Durak, 2. Hadımköy, 3. Cumhuriyet Mahallesi, 4. Beylikdüzü Belediye, 5. Beylikdüzü, 6. Güzelyurt, 7. Haramidere, 8. Haramidere Sanayi,  9. Saadetdere Mahallesi,  10. Mustafa Kemal Paşa, 11. Cihangir Üniversite Mahallesi, 12. Avcılar (İ.Ü.Kampüs), 13. Şükrübey, 14. İBB Sosyal Tesisler, 15. Küçükçekmece, 16. Cennet Mahallesi, 17. Florya, 18. Beşyol, 19. Sefaköy, 20. Yenibosna, 21. Şirinevler, 22. Bahçelievler, 23. İncirli, 24. Zeytinburnu, 25. Merter, 26. Cevizlibağ, 27. Topkapı, 28. Bayrampaşa - Maltepe, 29. Adnan Menderes Bulvarı, 30. Edirnekapı, 31. Ayvansaray, 32. Halıcıoğlu, 33. Okmeydanı, 34. Darülaceze - Perpa, 35. Okmeydanı Hastane, 36. Çağlayan, 37. Mecidiyeköy, 38. Zincirlikuyu";
            }
            if (comboBox1.Text == "34C Beylikdüzü-Cevizlibağ")
            {
                textBox1.Text = "1. Beylikdüzü Son Durak, 2. Hadımköy, 3. Cumhuriyet Mahallesi, 4. Beylikdüzü Belediye, 5. Beylikdüzü, 6. Güzelyurt, 7. Haramidere, 8. Haramidere Sanayi,  9. Saadetdere Mahallesi,  10. Mustafa Kemal Paşa, 11. Cihangir Üniversite Mahallesi, 12. Avcılar (İ.Ü.Kampüs), 13. Şükrübey, 14. İBB Sosyal Tesisler, 15. Küçükçekmece, 16. Cennet Mahallesi, 17. Florya, 18. Beşyol, 19. Sefaköy, 20. Yenibosna, 21. Şirinevler, 22. Bahçelievler, 23. İncirli, 24. Zeytinburnu, 25. Merter, 26. Cevizlibağ";
            }
            if (comboBox1.Text == "34G Beylikdüzü-Söğütlüçeşme")
            {
                textBox1.Text = "1. Beylikdüzü Son Durak, 2. Hadımköy, 3. Cumhuriyet Mahallesi, 4. Beylikdüzü Belediye, 5. Beylikdüzü, 6. Güzelyurt, 7. Haramidere, 8. Haramidere Sanayi,  9. Saadetdere Mahallesi,  10. Mustafa Kemal Paşa, 11.Cihangir Üniversite Mahallesi, 12. Avcılar (İ.Ü.Kampüs), 13. Şükrübey, 14. İBB Sosyal Tesisler, 15. Küçükçekmece, 16. Cennet Mahallesi, 17. Florya, 18. Beşyol, 19. Sefaköy, 20. Yenibosna, 21. Şirinevler, 22. Bahçelievler, 23. İncirli, 24. Zeytinburnu, 25. Merter, 26. Cevizlibağ, 27. Topkapı, 28. Bayrampaşa - Maltepe, 29. Adnan Menderes Bulvarı, 30. Edirnekapı, 31. Ayvansaray, 32. Halıcıoğlu, 33. Okmeydanı, 34. Darülaceze - Perpa, 35. Okmeydanı Hastane, 36. Çağlayan, 37. Mecidiyeköy, 38. Zincirlikuyu, 39. 15 Temmuz Şehitler Köprüsü, 40. Burhaniye, 41. Altunizade, 42. Acıbadem, 43. Uzunçayır, 44. Fikirtepe, 45. Söğütlüçeşme";
            }
            if (comboBox1.Text == "34Z Zincirlikuyu-Söğütlüçeşme")
            {
                textBox1.Text = " 38. Zincirlikuyu, 39. 15 Temmuz Şehitler Köprüsü, 40. Burhaniye, 41. Altunizade, 42. Acıbadem, 43. Uzunçayır, 44. Fikirtepe, 45. Söğütlüçeşme";
            }
            if (comboBox1.Text =="34B Beylikdüzü-Avcılar")
            {
                textBox1.Text = " 1. Beylikdüzü Son Durak, 2. Hadımköy, 3. Cumhuriyet Mahallesi, 4. Beylikdüzü Belediye, 5. Beylikdüzü, 6. Güzelyurt, 7. Haramidere, 8. Haramidere Sanayi,  9. Saadetdere Mahallesi,  10. Mustafa Kemal Paşa, 11. Cihangir Üniversite Mahallesi, 12. Avcılar (İ.Ü.Kampüs)";
            }
            if (comboBox1.Text== "34T Avcılar - Topkapı")
            {
                textBox1.Text = "12. Avcılar (İ.Ü.Kampüs), 13. Şükrübey, 14. İBB Sosyal Tesisler, 15. Küçükçekmece, 16. Cennet Mahallesi, 17. Florya, 18. Beşyol, 19. Sefaköy, 20. Yenibosna, 21. Şirinevler, 22. Bahçelievler, 23. İncirli, 24. Zeytinburnu, 25. Merter, 26. Cevizlibağ, 27. Topkapı";
            }
            if (comboBox1.Text== "34U Zincirlikuyu - Uzunçayır")
            {
                textBox1.Text = "38. Zincirlikuyu, 39. 15 Temmuz Şehitler Köprüsü, 40. Burhaniye, 41. Altunizade, 42. Acıbadem, 43. Uzunçayır";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void FrmMetrobus_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Minİstanbul Programı Metrobüs Durak ve Hat Bilgileri ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
