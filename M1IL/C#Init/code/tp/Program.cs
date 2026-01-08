using System;

namespace Initiation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  exo_1();
            //  exo_2();
            //  exo_3();
            //  exo_4_1();
            //  exo_4_2();
            //  exo_4_3();
            // exo_6("ROUGE");
            // exo_7();
            // exo_9();
            // exo_10();
            // exo_11();
            // Console.WriteLine(exo_12(7));
            // exo_13();
            // exo_14();
            // exo_15();
            // exo_16();
            // exo_17();
            // exo_18();
            // exo_19();
            // POUR L'EXO 20
            // int[] array1 = { 0, 1, 2, 3 };
            // int[] array2 = { 6, 7, 8 };
            // int index = 2;

            // int[] array3 = exo_20(array1, array2, index);

            // Console.WriteLine("array3:");
            // foreach (int number in array3)
            // {
            //     Console.Write(number + " ");
            // }
            // Console.WriteLine();
            // exo_21();
            // exo_22();
            exo_23();
        }

        public static void exo_1()
        {
            Console.Write("Entrez votre prénom : ");
            string ?prenom = Console.ReadLine();
            Console.Write("Entrez votre nom : ");
            string ?nom = Console.ReadLine();
            Console.WriteLine("Bonjour {0} {1} !", prenom, nom);
        }

        public static void exo_2()
        {
            Console.WriteLine("Quel est votre date de naissance ? format(jj/mm/aaaa)");
            string? date = Console.ReadLine();
            //DateTime datetime = DateTime.Parse(date);
            string[] splited = date!.Split('/');
            DateTime birthDate = new DateTime(int.Parse(splited[2]), int.Parse(splited[1]), int.Parse(splited[0]));

            int age = DateTime.Now.Year - birthDate.Year;
            bool birthdayPassed = birthDate.Month < DateTime.Now.Month || (birthDate.Month == DateTime.Now.Month && birthDate.Day <= DateTime.Now.Day);
            if (!birthdayPassed)
            {
                age--;
            }

            Console.WriteLine($"Vous avez {age} an(s).");

            TimeSpan ts = DateTime.Now - birthDate;
            int years = (int) MathF.Floor(ts.Days / 365.25f);
            int month = (int)((ts.Days - (years * 365.25f)) / 31f);
            int day = (int)(ts.Days - (365.25f * years) - (month * 31f));
            Console.WriteLine($"année : {years} mois : {month} jour : {day}");
        }

        public static void exo_3()
        {
            Console.Write("Tapez votre montant HT : ");
            string ?HT = Console.ReadLine();
            // Taper la TVA avec la forme 5,5 et pas 5.5
            Console.Write("Tapez le % de TVA : ");
            string ?TVA = Console.ReadLine();
            double HT_entier = double.Parse(HT!);
            double TVA_entier = double.Parse(TVA!)/100d;

            double ?TTC = (HT_entier*TVA_entier)+HT_entier;
            Console.WriteLine("Le montant TTC est : {0}€", TTC);
        }

        public static void exo_4_1(string Nombre1, string Nombre2)
        {
            try {
                int nb1 = int.Parse(Nombre1!);
                int nb2 = int.Parse(Nombre2!);
                int resultat = nb1 + nb2;
                Console.WriteLine("{0} + {1} = {2} !", nb1, nb2,resultat);
            } catch (FormatException e) {
                Console.WriteLine("On veut des chiffres !");
            }
        }

        public static void exo_4_2(string dividende, string diviseur)
        {
            try {
                int dividende_entier = int.Parse(dividende!);
                int diviseur_entier = int.Parse(diviseur!);
                int ?quotient = dividende_entier/diviseur_entier;
                int ?reste = quotient%diviseur_entier;
                Console.WriteLine("{0}/{1}={2} reste {3} !", dividende_entier, diviseur_entier, quotient,reste);
            } catch (DivideByZeroException e) {
                Console.WriteLine("On ne peut pas diviser par 0 !");
            } catch (FormatException e) {
                Console.WriteLine("On veut des chiffres !");
            }

        }
        public static void exo_4_3()
        {
            Console.Write("Entrez Numero1 : ");
            string ?Numero1 = Console.ReadLine();
            Console.Write("Entrez Numero2 : ");
            string ?Numero2 = Console.ReadLine();
            exo_4_1(Numero1!, Numero2!);
            exo_4_2(Numero1!, Numero2!);
        }

        public static void exo_6(string couleur)
        {
            string feu = "ORANGE";
            switch (couleur)
            {
                case "VERT":
                    feu = "ORANGE";
                    break;
                case "ORANGE":
                    feu = "ROUGE";
                    break;
                case "ROUGE":
                    feu = "VERT";
                    break;
            }
            Console.WriteLine("{0} !", feu);
        }

        public static void exo_7()
        {
            Console.Write("Entrez la temperature : ");
            int ?temperature = int.Parse(Console.ReadLine()!);
            switch (temperature)
            {
                case < 0:
                    Console.WriteLine("SOLIDE");
                    break;
                case > 100:
                    Console.WriteLine("GAZEUX");
                    break;
                default :
                    Console.WriteLine("LIQUIDE");
                    break;
            }
        }

        public static void exo_9()
        {
            try
            {
                Console.Write("Tapez le nombre 1 : ");
                int nb1 = int.Parse(Console.ReadLine()!);
                Console.Write("Tapez le nombre 2 : ");
                int nb2 = int.Parse(Console.ReadLine()!);
                Console.Write("Tapez le nombre 3 : ");
                int nb3 = int.Parse(Console.ReadLine()!);
                Random random = new Random();
                int nb4 = random.Next(1, 100);
                int nb5 = random.Next(1, 100);
                int nb6 = random.Next(1, 100);
                int[] maListeDeInt = { nb1, nb2, nb3, nb4, nb5, nb6 };
                Array.Sort(maListeDeInt);
                Array.Reverse(maListeDeInt);
                foreach (int nombre in maListeDeInt)
                {
                    Console.WriteLine(nombre);
                }
            }
            catch(Exception ex) {
                Console.WriteLine("error : {0}", ex.Message);
            }
        }

        public static void exo_10() {
            try
            {
                Console.Write("Tapez la valeur 1 : ");
                double a = double.Parse(Console.ReadLine()!);
                Console.Write("Tapez la valeur 2 : ");
                double b = double.Parse(Console.ReadLine()!);
                Console.Write("Tapez la valeur 3 : ");
                double c = double.Parse(Console.ReadLine()!);

                List<double> list = new List<double> { a, b, c };
                list.Sort();

                Console.WriteLine("-----------------------------------");

                foreach (double i in list)
                {
                    Console.WriteLine(i);
                }
            }
            catch(Exception ex) {
                Console.WriteLine("error : {0}", ex.Message);
            }
        }

        public static void exo_11() {
            for (int i = 0; i <= 20; i++)
            {
                if (i%2==0) {
                    Console.WriteLine(i);
                }
            }
        }

        public static int exo_12(int i) {
            if (i == 1) {
                return 1;
            }
            return i + exo_12(i-1);
        }

        public static void exo_13() {
            List<int> list = new List<int> {};
            for (int i = 0; i <= 30; i++)
            {
                if (i%3==0) {
                    list.Add(i);
                }
            }
            list.Sort();
            list.Reverse();
            string resultat = string.Join(" - ", list);
            Console.WriteLine(resultat);
        }

        public static void exo_14() {
            int nombre = 2;
            while (nombre <= 21) {
                Console.WriteLine(nombre);
                nombre+=3;
            }
        }

        public static void exo_15()
        {
            double somme = 0;

            Console.WriteLine("Entrez des nombres (tapez autre chose pour terminer) :");

            while (true)
            {
                string saisie = Console.ReadLine()!;
                double nombre;

                if (double.TryParse(saisie, out nombre))
                {
                    somme += nombre;
                }
                else
                {
                    break; // Sortir de la boucle si l'utilisateur entre autre chose
                }
            }

            Console.WriteLine("La somme des nombres entrés est : " + somme);
        }

        public static void exo_16() {
            Console.WriteLine("Entrez un nombre :");
            double n = double.Parse(Console.ReadLine()!);
            int nombreDeDivisions = 0;

            while (n > 1)
            {
                n /= 2;
                nombreDeDivisions++;
            }

            Console.WriteLine("Il a fallu {0} divisions pour atteindre un résultat inférieur ou égal à 1.", nombreDeDivisions);
        }

        static void exo_17() {
            // Créer un tableau d'entiers
            int[] tableau = new int[9]; // 9 éléments pour contenir les chiffres de 5 à 13

            // Remplir le tableau avec les chiffres entre 5 et 13
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = i + 5;
            }

            // Remplacer le 3e élément du tableau par 111
            tableau[2] = 111;

            // Afficher tous les éléments du tableau
            Console.WriteLine("Éléments du tableau :");
            foreach (int nombre in tableau)
            {
                Console.WriteLine(nombre);
            }
        }

        static void exo_18() {
            int[] tableau = { 2, 7, 10, 4, 8, 6, 12, 5 };

            Console.WriteLine("Tableau original :");
            foreach (int nombre in tableau)
            {
                Console.Write(nombre + " ");
            }
            Console.WriteLine();

           for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] % 2 == 0) // Vérifier si le nombre est pair
                {
                    tableau[i] = i; // Remplacer le nombre pair par son index
                }
            }

            Console.WriteLine("\nTableau modifié :");
            foreach (int nombre in tableau)
            {
                Console.Write(nombre + " ");
            }
            Console.WriteLine();
        }

        static void exo_19() {
            int[] tableau1 = { 1, 3, 5, 7 };
            int[] tableau2 = { 2, 4, 6, 8, 10, 12, 45 };
            int i = 0;
            int j = 0;
            int k = 0;
            int[] tableauResultat = new int[tableau1.Length + tableau2.Length];

            if (tableau1.Length < tableau2.Length) {
                while (i<tableau1.Length) {
                    tableauResultat[k] = tableau1[i];
                    tableauResultat[k+1] = tableau2[j];
                    i++;
                    j++;
                    k+=2;
                }
                while (j<tableau2.Length) {
                    tableauResultat[k] = tableau2[j];
                    j++;
                    k++;
                }
            } else if (tableau1.Length > tableau2.Length) {
                while (j<tableau2.Length) {
                    tableauResultat[k] = tableau1[i];
                    tableauResultat[k+1] = tableau2[j];
                    i++;
                    j++;
                    k+=2;
                }
                while (i<tableau1.Length) {
                    tableauResultat[k] = tableau1[i];
                    i++;
                    k++;
                }
            } else {
                while (i<tableau1.Length) {
                    tableauResultat[k] = tableau1[i];
                    tableauResultat[k+1] = tableau2[j];
                    i++;
                    j++;
                    k+=2;
                }
            }

            Console.WriteLine("\nTableau final :");
            foreach (int nombre in tableauResultat)
            {
                Console.Write(nombre + " ");
            }
            Console.WriteLine();
        }

        // Écrire une fonction qui insère un tableau à un index précis dans un autre tableau.
        // Exemple
        // array1 = {0,1,2,3};
        // array2 = {6,7,8};
        // array3 = F(array1,array2,2);
        //array3
        // {0,1,6,7,8, 2,3}
        static int[] exo_20(int[] destinationArray, int[] sourceArray, int insertionIndex) {
            int totalLength = destinationArray.Length + sourceArray.Length;
            int[] resultArray = new int[totalLength];

            // Copier les éléments de destinationArray avant l'index spécifié
            for (int i = 0; i < insertionIndex; i++)
            {
                resultArray[i] = destinationArray[i];
            }

            // Copier les éléments de sourceArray à partir de l'index spécifié
            for (int i = 0; i < sourceArray.Length; i++)
            {
                resultArray[insertionIndex + i] = sourceArray[i];
            }

            // Copier les éléments restants de destinationArray après l'insertion de sourceArray
            for (int i = insertionIndex; i < destinationArray.Length; i++)
            {
                resultArray[sourceArray.Length + i] = destinationArray[i];
            }

            return resultArray;
        }

        // Ecrire un programme qui remplit
        // un tableau avec tous les caractères
        // d’un mot tapé par l’utilisateur.
        // •
        // Afficher le mot contenu dans le
        // tableau en intercalent un « »
        // entre chaque lettre.
        // •
        // Inverser le contenu du tableau puis
        // afficher le mot obtenu dans la
        // console.
        public static void exo_21()
        {
            Console.WriteLine("Veuillez taper un mot : ");
            string? mot = Console.ReadLine();
            char[] motCharArray = mot.ToCharArray();
            for (int i=0; i < motCharArray.Length; i++) {
                Console.WriteLine(motCharArray[i]);
                if (i != motCharArray.Length - 1) {
                    Console.WriteLine(".");
                }
            }

            int j = motCharArray.Length - 1;
            for(int i=0; i<motCharArray.Length/2; i++) {
                char temp = motCharArray[i];
                motCharArray[i] = motCharArray[j];
                motCharArray[j] = temp;
                j--;
            }

            Console.Write("\nMot inversé :");
            for (int i = 0; i < motCharArray.Length; i++)
            {
                Console.Write(motCharArray[i] + " ");
            }
        }

        public static void exo_22()
        {
            Console.WriteLine("Veuillez taper un mot avec des # : ");
            string? mot = Console.ReadLine();
            string? res = mot.Replace('#', ' ');
            Console.WriteLine(res);
        }

        public static void exo_23()
        {
            Console.WriteLine("Veuillez taper un mot pour tester s\'il est palindrome : ");
            string? mot = Console.ReadLine();
            bool isPalindrome = true;
            int i = 0;
            int j = mot.Length - 1;
            while (i < mot.Length/2 && j > mot.Length/2) {
                if(mot[i] != mot[j]) {
                    isPalindrome = false;
                    Console.WriteLine("Ce mot n\'est pas un palindrome.");
                    break;
                }
                i++;
                j--;
            }
            if (isPalindrome) {
                Console.WriteLine("Ce mot est palindrome.");
            }
        }
    }
}