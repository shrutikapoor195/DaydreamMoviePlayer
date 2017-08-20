using System;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;
#endif

#if !UNITY_EDITOR
public class BaseHierarchySort : System.Collections.Generic.IComparer<GameObject>
{
    public virtual int Compare(GameObject lhs, GameObject rhs)
    {
        return 0;
    }

    public virtual GUIContent content { get { return GUIContent.none; } }
}
#endif

public static class GameObjectExtension
{

    private class BaseHierarchySortCompare : IComparer<GameObject>
    {
        private readonly BaseHierarchySort _hierarchySort;

        public BaseHierarchySortCompare(Type hierarchySortType)
        {
            _hierarchySort = (BaseHierarchySort)Activator.CreateInstance(hierarchySortType);
        }

        public int Compare(GameObject x, GameObject y)
        {
            return _hierarchySort.Compare(x, y);
        }
    }

    /// <summary>
    /// タイプのオブジェクトをすべて取得し，BaseHierarchySortで比較してソートする
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <returns></returns>
    public static TSource[] FindObjectsOfType<TSource, TKey>()
        where TSource : Component
            where TKey : BaseHierarchySort
    {
        var objs = Object.FindObjectsOfType<TSource>();
        return objs.OrderBy(obj => obj.gameObject, new BaseHierarchySortCompare(typeof(TKey))).ToArray();
    }

    /// <summary>
    /// Tag名からゲームオブジェクトをすべて取得し，BaseHierarchySortで比較してソートする
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="tag"></param>
    /// <returns></returns>
    public static GameObject[] FindGameObjectsWithTag<T>(string tag) where T : BaseHierarchySort
    {
        var gameObjects = GameObject.FindGameObjectsWithTag(tag).ToList();
        gameObjects.Sort(new BaseHierarchySortCompare(typeof(T)));
        return gameObjects.ToArray();
    }

    /// <summary>
    /// Tag名かつ条件に合うゲームオブジェクトをすべて取得
    /// </summary>
    /// <param name="tag">タグ名</param>
    /// <param name="condition">条件</param>
    /// <returns>条件にあったゲームオブジェクト</returns>
    /// <example>
    /// // Rigidbodyがアタッチされているゲームオブジェクトをすべて取得
    /// var gameObjects = GameObjectExtension.FindGameObjectsWithTag("Player", go => go.GetComponent<Rigidbody>());
    /// </example>
    public static GameObject[] FindGameObjectsWithTag(string tag, Predicate<GameObject> condition)
    {
        return GameObject.FindGameObjectsWithTag(tag).Where(go => condition(go)).ToArray();
    }

    /// <summary>
    /// Tag名かつ条件に合うゲームオブジェクトをすべて取得
    /// 全取得した後，条件に合うゲームオブジェクトを取得するので速度は遅い。
    /// </summary>
    /// <param name="tag">タグ名</param>
    /// <param name="condition">条件</param>
    /// <returns></returns>
    public static GameObject FindGameObjectWithTag(string tag, Predicate<GameObject> condition)
    {
        return GameObject.FindGameObjectsWithTag(tag).FirstOrDefault(go => condition(go));
    }

    /// <summary>
    /// 条件に合うタイプのオブジェクトを取得
    /// 全取得した後，条件に合うオブジェクトを取得するので速度は遅い
    /// </summary>
    /// <typeparam name="T">タイプ</typeparam>
    /// <param name="condition">条件</param>
    /// <returns>最初に条件にあったオブジェクトを返す</returns>
    public static T FindObjectOfType<T>(Predicate<T> condition) where T : Object
    {
        return Object.FindObjectsOfType<T>().FirstOrDefault(o => condition(o));
    }

    /// <summary>
    /// 条件に合うタイプのオブジェクトをすべて取得
    /// </summary>
    /// <typeparam name="T">タイプ</typeparam>
    /// <param name="condition">条件</param>
    /// <returns>条件にあったすべてのオブジェクトを返す</returns>
    public static T[] FindObjectsOfType<T>(Predicate<T> condition) where T : Object
    {
        return Object.FindObjectsOfType<T>().Where(o => condition(o)).ToArray();
    }

    /// <summary>
    /// オブジェクトの複製
    /// </summary>
    /// <typeparam name="T">複製されるオブジェクトのタイプ</typeparam>
    /// <param name="original">複製されるオブジェクト</param>
    /// <param name="position">位置</param>
    /// <param name="rotation">角度</param>
    /// <returns>複製されたオブジェクトを返す</returns>
    public static T Instantiate<T>(T original, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion)) where T : Object
    {
        return (T)Object.Instantiate(original, position, rotation);
    }

    public static void SetTagRecursively(this GameObject gameObject, string tag)
    {
        gameObject.tag = tag;
        foreach (Transform child in gameObject.transform)
            child.gameObject.tag = tag;
    }

    public static void SetLayerRecursively(this GameObject gameObject, int layer)
    {
        gameObject.layer = layer;
        foreach (Transform child in gameObject.transform)
            child.gameObject.layer = layer;
    }

    public static void SetLayerRecursively(this GameObject gameObject, string layerName)
    {
        gameObject.SetLayerRecursively(LayerMask.NameToLayer(layerName));
    }
}