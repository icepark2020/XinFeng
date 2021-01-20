using System;
using System.Windows.Forms;

namespace XinFeng
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        //private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
        //{
        //    //项目的命名空间为myapp, 嵌入dll资源在libs文件夹下，所以这里用的命名空间为： myapp.libs.
        //    string _resName = "myapp.libs." + new AssemblyName(e.Name).Name + ".dll";
        //    using (var _stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(_resName))
        //    {
        //        byte[] _data = new byte[_stream.Length];
        //        _stream.Read(_data, 0, _data.Length);
        //        return Assembly.Load(_data);
        //    }

        //}



    }
}
