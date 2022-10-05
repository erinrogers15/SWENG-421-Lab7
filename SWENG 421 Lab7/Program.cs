namespace SWENG_421_Lab7
{
    public interface NovelElementIF
    {

    }
    public interface NovelElementIF2 : NovelElementIF
    {

    }
    public abstract class CompositeNovelElement : NovelElementIF
    {

    }
    public class Novel : NovelElementIF2, AdminitratorIF
    {
        public void save()
        {

        }
        public NovelElementIF retrieve()
        {
            return null;
        }
        public void view()
        {

        }
        public void edit()
        {

        }
        public void delete()
        {

        }

    }
    public class Page : CompositeNovelElement
    {

    }
    public class Column : CompositeNovelElement
    {

    }
    public class Frame : CompositeNovelElement 
    {

    }
    public class Image : NovelElementIF
    {

    }
    public class LineOfText : CompositeNovelElement 
    {

    }
    public class Character : NovelElementIF
    {

    }
    public interface AdminitratorIF: EditorIF, WriterIF
    {

    }
    public class Administrator
    {
       
    }

    public interface EditorIF
    {
        void save();
        NovelElementIF retrieve();
        void delete();

    }

    public class Editor
    {

    }
    public interface WriterIF
    {
        void view();
        void edit();
    }
    public class Writer
    {

    }
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}