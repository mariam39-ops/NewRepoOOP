namespace OOP_asgimentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer 1
            //A: struct is a value type the storege is in the stacke momery ,لما نساوي اوبجيكت باوبجيكت معناها انه 
            //بياخد كوبي من الداتا مش referanceمنها يعني هو اخد كوبي وحطها فى حته تانيه اي تعديل فى اي اوبجيككت منهم 
            //مش هياثر على التاني نهائيا
            // B: class is a referance type  the storege part in the stack (address) value in the head
            //لما ننسخ اوبجيكت جوهاوبجيكت مش بيلخد كوبى من الvalue هو بياخد نفس الadressفبتالي لو عدلت فى 
            //اي واحد منهم هياثر على الثاني لانهم بيشاورو على نفس المكان 

            #endregion
            #region answer 2
            //A:acces modifer public: ليها عده مشاكل 
            //عدم وجود طبقه حمايه على الfield اي حد يقدر يستخدمها فى اي مكان 
            //ممكن يحصل تداخل بسبب ان اسم الfield موجود فى اكتر من كلاس مثلا 
            //محميتش الfield من  devoloper الى شغال معايا لانه ممكن يستخدمها بالغلط
            //عند التغيير فى اسم الfield بتضطر اغيرها فى اي مكان استخطمته ولو الكود كتير يبقي ده صعب
            //صعوبه عمل valdation عليها
            //b:private:كده هبقي مطمن ان حميتها من اي خطا ممكن يحصل بدون قصد
            //كمان هستخدم الget&setوده هيبقي منظم اكتر واقدر كمان اعمل valdation فى نفس السطر
            //حميتها من ان يحصل تعارض بينها وبين field فى كلاس تاني بسبب تشابهه الاسماء

            #endregion
            #region answer 3
            DeliveryAdress d1 = new DeliveryAdress("mansoura", "Glaa",43);
            DeliveryAdress d2 = d1;
            Console.WriteLine(d1.GetFullAdress());
            Console.WriteLine(d2.GetFullAdress());
            d2.setCity("cairo");
            d2.setStreet("Ahmed Araby");
            d2.setBuldingNum(88);
            Console.WriteLine(d1.GetFullAdress());
            Console.WriteLine(d2.GetFullAdress());




            #endregion
        }
    }
}
