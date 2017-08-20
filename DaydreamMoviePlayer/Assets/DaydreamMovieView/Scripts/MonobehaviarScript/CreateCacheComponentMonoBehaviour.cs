using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
public class CreateCacheComponentMonoBehaviour
{
    [MenuItem("Assets/Create CacheComponentMonoBehaviour")]
    static void CreateScript()
    {
        //CacheComponentMonoBehaviour.cs のスクリプトをテキストで生成する
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("using UnityEngine;");
        sb.AppendLine("using UnityEngine.Experimental.Director;");
        sb.AppendLine("using UnityEngine.Networking.Match;");

        sb.AppendLine("");
        sb.AppendLine("public class CacheComponentMonoBehaviour : MonoBehaviour");
        sb.AppendLine("{");
        foreach (var type in Assembly.Load("UnityEngine.dll").GetTypes())
        {
            // コンポーネント&非推奨ではない&MonoBehaviour ではない
            if (type.IsSubclassOf(typeof(Component))
            && type.IsPublic
            && IsObsolete(type) == false
            && type != typeof(MonoBehaviour))
            {
                var name = type.Name;
                sb.AppendFormat("\tprivate {0} m_{1};\n\n", name, name);
                sb.AppendFormat("\tpublic {0} cached{1} {{\n", name, name);
                sb.AppendLine("\t\tget {");
                sb.AppendFormat("\t\t\tif (m_{0} == null)\n", name);
                sb.AppendFormat("\t\t\t\tm_{0} = GetComponent<{1}> ();\n", name, name);
                sb.AppendFormat("\t\t\treturn m_{0};\n", name);
                sb.AppendLine("\t\t}");
                sb.AppendLine("\t}");
                sb.AppendLine();
            }
        }
        sb.Append("}");
        string path = "Assets/CacheComponentMonoBehaviour.cs";
        //全ての Runtime スクリプトを取得して CacheComponentMonoBehaviour.cs が存在すれば取得する
        var importer = MonoImporter.GetAllRuntimeMonoScripts()
        .Where(i => i.GetClass() != null
       && i.GetClass().Name == "CacheComponentMonoBehaviour")
        .FirstOrDefault();
        //存在すれば上書きする
        if (importer)
        {
            path = AssetDatabase.GetAssetPath(importer);
        }
        File.WriteAllText(path, sb.ToString());
        AssetDatabase.ImportAsset(path);
    }
    //非推奨かどうか
    static bool IsObsolete(System.Type type)
    {
        return type.GetCustomAttributes(typeof(System.ObsoleteAttribute), true).Length != 0;
    }
}