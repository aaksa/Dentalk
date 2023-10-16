using System;
using System.Collections.Generic;
using UnityEngine;

public class DentalIssuesDatabase : MonoBehaviour
{
    public List<DentalIssue> issues;

    public Sprite spriteGigiNormal;
    public Sprite spriteKariesOklusal;
    public Sprite spriteKariesPalatal;
    public Sprite spriteKariesPalatalGigiSeri;
    public Sprite spriteKariesInisiasi;
    public Sprite spriteKariesTahapKedua;
    public Sprite spriteKariesTahapKetiga;
    public Sprite spriteKariesAnakDuaTahun;
    public Sprite spriteKariesAnakEmpatTahun;
    public Sprite spriteKariesOklusalGigiGeraham;

    private void Awake()
    {
        // Assign sprite references to the dental issues
        issues = new List<DentalIssue>
        {
            new DentalIssue
            {
                id = 1,
                image = spriteGigiNormal,
                nama = "Gigi Sehat",
                penyebab = "Untuk menjaga kesehatan gigi anak dan mencegah karies, perlu diperhatikan beberapa hal penting. Pertama, pastikan anak menyikat gigi setidaknya dua kali sehari dengan menggunakan pasta gigi yang mengandung fluoride. Pilihlah sikat gigi dengan bulu lembut yang sesuai dengan usia mereka. Selanjutnya, batasi konsumsi makanan manis dan minuman bersoda dalam diet anak. Incentivize minum air setelah makan untuk membantu membersihkan sisa-sisa makanan. Terakhir, pastikan untuk menjadwalkan kunjungan ke dokter gigi secara teratur, setidaknya sekali setahun.",
                penanganan = "Selain itu, dalam mendidik anak untuk menjaga kesehatan gigi mereka, hindari memberikan botol susu di malam hari, karena susu yang menetap di gigi dapat menyebabkan karies. Ajarkan teknik menyikat gigi yang benar dengan gerakan lembut dan merata. Perkenalkan makanan sehat yang kaya kalsium dan vitamin dalam diet mereka. Berikan pujian dan hadiah sebagai insentif positif setelah anak menyelesaikan rutinitas menyikat gigi. Terakhir, penting untuk memantau perkembangan gigi anak secara teratur dan berkonsultasi dengan dokter gigi jika ada masalah yang perlu diperhatikan."
            },
            new DentalIssue
            {
                id = 2,
                image = spriteKariesOklusal,
                nama = "Karies Oklusal",
                penyebab = "Karies Oklusal pada gigi anak dapat disebabkan oleh akumulasi plak dan sisa makanan di daerah oklusal gigi, terutama pada gigi molar. Plak bakteri yang menumpuk di sana dapat merombak enamel gigi, menyebabkan karies",
                penanganan = "Cara mengatasinya dengan mengedukasi anak dan orang tua tentang pentingnya menjaga kebersihan gigi, termasuk menyikat gigi secara teratur dan membersihkan daerah oklusal dengan benar. Mungkin juga perlu dilakukan sealing gigi untuk melindungi permukaan oklusal."
            },
            new DentalIssue
            {
                id = 3,
                image = spriteKariesPalatal,
                nama = "Karies Palatal",
                penyebab = "Karies Palatal pada gigi anak dapat terjadi akibat plak dan kotoran yang tertinggal pada permukaan palatal gigi, terutama pada gigi seri.",
                penanganan = "Cara mengatasinya dengan anak harus diajari untuk membersihkan bagian palatal gigi dengan lembut menggunakan sikat gigi yang sesuai. Dokter gigi juga dapat memberikan saran tentang teknik menyikat yang benar dan mungkin meresepkan pasta gigi dengan fluoride untuk memperkuat enamel."
            },
            new DentalIssue
            {
                id = 4,
                image = spriteKariesPalatalGigiSeri,
                nama = "Karies Palatal Pada Gigi Seri",
                penyebab = "Palatal pada gigi seri bisa menjadi masalah jika anak sering mengisap jempol atau benda keras lainnya. Ini dapat mengakibatkan pergeseran gigi seri ke arah palatal.",
                penanganan = "Cara mengatasinya adalah mencoba menghentikan kebiasaan mengisap tersebut dan konsultasi dengan dokter gigi anak untuk memantau perkembangan gigi serta mungkin merencanakan perawatan ortodontik jika diperlukan."
            },
            new DentalIssue
            {
                id = 5,
                image = spriteKariesInisiasi,
                nama = "Karies Tahap Inisiasi",
                penyebab = "Karies tahap inisiasi adalah tahap awal dari karies gigi di mana email belum rusak sepenuhnya",
                penanganan = "Untuk mengatasi ini, penting untuk memulai perawatan segera dengan menghilangkan plak, mengadopsi pola makan yang sehat, dan mungkin melakukan aplikasi fluoride topikal untuk menguatkan enamel."
            },
            new DentalIssue
            {
                id = 6,
                image = spriteKariesTahapKedua,
                nama = "Karies Tahap Kedua",
                penyebab = "Karies tahap kedua adalah tahap di mana kerusakan gigi telah melibatkan lapisan enamel dan mencapai dentin.",
                penanganan = "Cara mengatasinya dengan membawa anak ke dokter gigi. Dokter gigi akan melakukan perawatan restoratif seperti pengisian gigi dengan bahan aman untuk anak-anak."
            },
            new DentalIssue
            {
                id = 7,
                image = spriteKariesTahapKetiga,
                nama = "Karies Tahap Ketiga",
                penyebab = "Karies tahap ketiga adalah tahap lanjut di mana kerusakan gigi telah mencapai pulpa atau saraf gigi",
                penanganan = " Dalam kasus ini, perawatan akar gigi atau ekstraksi mungkin diperlukan untuk mengatasi infeksi."
            },
            new DentalIssue
            {
                id = 8,
                image = spriteKariesAnakDuaTahun,
                nama = "Karies Pada Anak Dua Tahun",
                penyebab = "Karies pada anak dua tahun dapat disebabkan oleh paparan terlalu sering terhadap makanan dan minuman manis.",
                penanganan = "Cara mengatasinya adalah dengan mengurangi konsumsi gula, memberikan air minum setelah makan, dan mengajarkan kebiasaan menyikat gigi setelah makan."
            },
            new DentalIssue
            {
                id = 9,
                image = spriteKariesAnakEmpatTahun,
                nama = "Karies Pada Anak Empat Tahun",
                penyebab = "Karies pada anak empat tahun bisa menjadi masalah serius jika tidak diatasi. Penting untuk mengadopsi kebiasaan pola makan yang sehat, menghindari camilan berlebihan, dan tetap menjaga kebersihan gigi dengan rajin.",
                penanganan = "Cara mengatasinya dengan menerapkan pola makan yang sehat dan tetap menjaga kebersihan gigi dengan rajin"
            },
            new DentalIssue
            {
                id = 10,
                image = spriteKariesOklusalGigiGeraham,
                nama = "Karies Pada Oklusal Gigi Geraham",
                penyebab = "Karies pada oklusal gigi geraham terjadi karena plak bakteri menumpuk di sela-sela geraham.",
                penanganan = "Cara mengatasinya dengan membawa anak ke dokter gigi. Dokter gigi dapat melakukan sealing gigi pada daerah tersebut untuk mencegah karies, dan anak harus diajari untuk membersihkan dengan benar bagian oklusal."
            },
            // Add more dental issues here
        };
    }
}
