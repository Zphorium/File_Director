using System;

namespace File_Director
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ###########################################");
            Console.WriteLine(" Welcome to Zphorium's file director server");
            Console.WriteLine(" ###########################################");
            Console.WriteLine(" First u need to chose your main language ");
            Console.WriteLine(" ###########################################");
            Console.Write(" Use /language to see the language settings you can use : ");

            string helpCommand = Console.ReadLine();

            if (helpCommand == "/language")
            {
                Console.WriteLine(" ###########################");
                Console.WriteLine(" /eng");
                Console.WriteLine(" /aze");
                Console.WriteLine(" /ru");
                Console.WriteLine(" ###########################");
            }
            string secondStage = Console.ReadLine();

            if (secondStage == "/eng")
            {
                Console.WriteLine("  Hi. Pls enter your files :");
            }

            else if (secondStage == "/aze")
            {
                Console.WriteLine("  Salam. Zəhmət olmasa faylnızı daxil edin :");
            }

            else if (secondStage == "ru")
            {
                Console.WriteLine("  Privet. Pojalusta, vvedite vashi fayli ваши файлы :");
            }
            else
            {
                Console.WriteLine("  Your command is not found bye ");                
            }



            if (secondStage == "/eng" || secondStage == "/aze" || secondStage == "ru")
            {
             EnteredFiles enteredFile = new EnteredFiles(Console.ReadLine());
            }
        }
    }

    class EnteredFiles
    {
        string _filetypsPdf;
        string _filetypsJpg;
        string _filetypsDocx;

        public EnteredFiles(string filetyp)
        {
            if (IsEnteredFilePdf(filetyp))
            {
                _filetypsPdf = filetyp;
                Console.WriteLine("Your file is 'Pdf'");
            }

            else if (IsEnteredFileJpg(filetyp))
            {
                _filetypsJpg = filetyp;
                Console.WriteLine("Your file is 'Jpd'");
            }

            else if (IsEnteredFileDocx(filetyp))
            {
                _filetypsDocx = filetyp;
                Console.WriteLine("Your file is 'Docx'");
            }

            else
            {
                Console.WriteLine("Your entred data is not found");
            }
        }


        static bool IsEnteredFilePdf(string filetyp)
        {
            if (!IsEntetredFileIsPdf(filetyp))
            {
                return false;
            }
            return true;
        }

        static bool IsEnteredFileJpg(string filetyp)
        {
            if (!IsEntetredFileIsJpd(filetyp))
            {
                return false;
            }

            return true;
        }

        static bool IsEnteredFileDocx(string filetyp)
        {
            if (!IsEntetredFileIsDocx(filetyp))
            {
                return false;
            }

            return true;
        }


        //Comman methods

        public static bool IsEntetredFileIsPdf(string fileName)
        {
            string extensionPdf = ".pdf";
            if (fileName.EndsWith(extensionPdf))
            {
                return true;
            }

            return false;
        }
        public static bool IsEntetredFileIsJpd(string fileName)
        {
            string extensionJpd = ".jpd";
            if (fileName.EndsWith(extensionJpd))
            {
                return true;
            }

            return false;
        }
        public static bool IsEntetredFileIsDocx(string fileName)
        {
            string extensionDocx = ".docx";
            if (fileName.EndsWith(extensionDocx))
            {
                return true;
            }

            return false;
        }
    }
}
