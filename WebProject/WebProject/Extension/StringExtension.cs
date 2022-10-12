using System.Text.Json;

namespace WebProject.Extension
{
    public static class Extension
    {
        /// <summary>
        /// Json字串映射物件
        /// </summary>
        /// <typeparam name="T">物件型別</typeparam>
        /// <param name="str">JSON字串</param>
        /// <returns>反序列化物件</returns>
        public static T JsonMap<T>(this string str)
        {
            // === 取得反序列化物件(不區分大小寫的比較來比較屬性名稱) ===
            return JsonSerializer.Deserialize<T>(str, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
