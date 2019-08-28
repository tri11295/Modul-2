using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.bt2
{
    class PhotoAbum
    {
        public class PhotoAlbum
        {
            public int numberOfPages;

            public PhotoAlbum()
            {
                numberOfPages = 16;
            }
            public PhotoAlbum(int Pages)
            {
                numberOfPages = Pages;
            }
            public int GetNumberOfPages()
            {
                return numberOfPages;
            }
        }

        public class BigPhotoAlbum : PhotoAlbum
        {
            
            public BigPhotoAlbum()
            {
                numberOfPages = 64;
            }
        }

        public class AlbumTest
        {
            static void Main()
            {
                var Album1 = new PhotoAlbum(); 
                Console.WriteLine("Pages of Album1 {0}", Album1.GetNumberOfPages());

                var myAlbum2 = new PhotoAlbum(24);
                Console.WriteLine("Pages of Album2 {0}",myAlbum2.GetNumberOfPages());

                var myBigPhotoAlbum = new BigPhotoAlbum();
                Console.WriteLine("Pages of myBigPhotoAlbum {0}",myBigPhotoAlbum.GetNumberOfPages());
            }
        }




    }
}
