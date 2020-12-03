namespace OOP_2020.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OOP_2020.OOPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OOP_2020.OOPContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Student s1 = new Student("Иван", "Иванович", "Иванов", new DateTime(2001, 2, 11), "Киров");
            Student s2 = new Student("Петр", "Петрович", "Петров", new DateTime(2002, 6, 21), "Кирово-Чепецк");

            Group g1 = new Group { Name = "Гр-1" };
            Group g2 = new Group { Name = "Гр-2" };

            g1.Students.Add(s1);
            s1.Group = g1;

            g2.Students.Add(s2);
            s2.Group = g2;

            Speciality sp = new Speciality();
            sp.Name = "Информационная безопасность";

            g1.Speciality = sp;
            g2.Speciality = sp;

            Discipline d = new Discipline { Name = "Программирование" };

            sp.Disciplines.Add(d);
            d.Specialities.Add(sp);


            context.Students.Add(s1);
            context.Students.Add(s2);
            context.Groups.Add(g1);
            context.Groups.Add(g2);
            context.Disciplines.Add(d);
            context.Specialities.Add(sp);

            context.SaveChanges();


        }
    }
}
