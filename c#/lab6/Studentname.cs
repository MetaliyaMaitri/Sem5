using System.Collections;


class Studentname
{
    ArrayList a1 = new ArrayList();
    public void DisplayElements()
    {
        if (a1.Count > 0)
        {
            foreach (int i in a1)
            {
                Console.WriteLine(i.ToString());
            }
        }
        else
        {
            Console.WriteLine("element not found");
        }
    }
    public void ArrayListMethod()
    {
       int  Flag = 0;
        while (Flag == 0)
        {
            Console.WriteLine("Enter element ");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Remove ");
            Console.WriteLine("3.RemoveRange ");
            Console.WriteLine("4.Clear");
            Console.WriteLine("5.exist");
            Console.WriteLine("Chose to any one option  ");
            int ch = Convert.ToInt32(Console.ReadLine());
            

            switch (ch)
            {
                case 1:
                    Console.Write("Enter Element : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    a1.Add(n);

                    DisplayElements();
                    break;
                case 2:
                    Console.Write("Enter Element : ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    if (a1.Count > 0)
                        a1.Remove(no);
                    DisplayElements();
                    break;
                case 3:
                    Console.Write("Enter Index : ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Count of Elements: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    if (a1.Count > 0)
                        a1.RemoveRange(n1, n2);
                    DisplayElements();
                    break;
                case 4:
                    a1.Clear();
                    DisplayElements();
                    break;
                case 5:
                    Flag = 1;
                    break;
                default:
                    break;
            }

            }
    }
}