        namespace DemoVaishnavi
{
    class anonymous
    {
        public static void sampleMethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.s_name);
            Console.WriteLine(val.language);

        } 
        public static void Main()
        {
            var anony_object=new {
                s_id=123,
                s_name="Vaishnavi",
                language="English"
            };
            sampleMethod(anony_object);
 }
    }
}