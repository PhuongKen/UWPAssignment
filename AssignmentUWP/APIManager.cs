using AssignmentUWP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUWP
{
    class APIManager
    {
        public static async Task<List<RootObject>> GetData()
        {
            var http = new HttpClient();
            var url = String.Format("http://tommyprivateguide.com/wp-json/wp/v2/posts?param%2Fdata.json&fbclid=IwAR07loTbIgHmtSQ_dTB7MXV9zM0G4TcOpXmQKmOjT6TtzhX5UbJHazJ_ePw");
            var response = await http.GetAsync(url); // Nhan data user tu weathermap.org
            var result = await response.Content.ReadAsStringAsync();

            // Doc object da phan tich duoc tu json vao stream local de phan tich
            List<RootObject> data = JsonConvert.DeserializeObject<List<RootObject>>(result);
            return data;
        }
    }

    public class Guid
    {
        public string rendered { get; set; }
    }

    public class Title
    {
        public string rendered { get; set; }
    }

    public class Content
    {
        public string rendered { get; set; }
        public bool @protected { get; set; }
    }

    public class Excerpt
    {
        public string rendered { get; set; }
        public bool @protected { get; set; }
    }

    public class Thumbnail
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
//        public string __invalid_name__mime-type { get; set; }
//        public string source_url { get; set; }
       }

public class Medium
{
    public string file { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    //public string __invalid_name__mime-type { get; set; }
    public string source_url { get; set; }
}

    public class SparklingFeatured
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        //public string __invalid_name__mime-type { get; set; }
        //public string source_url { get; set; }
    }

    public class TabSmall
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        //public string __invalid_name__mime-type { get; set; }
        //public string source_url { get; set; }
    }

    public class Large
    {
        public string file { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        //public string __invalid_name__mime-type { get; set; }
        //public string source_url { get; set; }
    }

    public class Sizes
    {
        public Thumbnail thumbnail { get; set; }
        public Medium medium { get; set; }
        //public SparklingFeatured __invalid_name__sparkling-featured { get; set; }
        //public TabSmall __invalid_name__tab-small { get; set; }
        public Large large { get; set; }
    }

    public class ImageMeta
    {
        public int aperture { get; set; }
        public string credit { get; set; }
        public string camera { get; set; }
        public string caption { get; set; }
        public int created_timestamp { get; set; }
        public string copyright { get; set; }
        public object focal_length { get; set; }
        public object iso { get; set; }
        public object shutter_speed { get; set; }
        public string title { get; set; }
        public int orientation { get; set; }
    }

    public class MediaDetails
    {
        public int width { get; set; }
        public int height { get; set; }
        public string file { get; set; }
        public Sizes sizes { get; set; }
        public ImageMeta image_meta { get; set; }
    }

    public class BetterFeaturedImage
    {
        public int id { get; set; }
        public string alt_text { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public string media_type { get; set; }
        public MediaDetails media_details { get; set; }
        public int? post { get; set; }
        public string source_url { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Collection
    {
        public string href { get; set; }
    }

    public class About
    {
        public string href { get; set; }
    }

    public class Author
    {
        public bool embeddable { get; set; }
        public string href { get; set; }
    }

    public class Reply
    {
        public bool embeddable { get; set; }
        public string href { get; set; }
    }

    public class VersionHistory
    {
        public string href { get; set; }
    }

    public class WpFeaturedmedia
    {
        public bool embeddable { get; set; }
        public string href { get; set; }
    }

    public class WpAttachment
    {
        public string href { get; set; }
    }

    public class WpTerm
    {
        public string taxonomy { get; set; }
        public bool embeddable { get; set; }
        public string href { get; set; }
    }

    public class Cury
    {
        public string name { get; set; }
        public string href { get; set; }
        public bool templated { get; set; }
    }

    public class Links
    {
        public List<Self> self { get; set; }
        public List<Collection> collection { get; set; }
        public List<About> about { get; set; }
        public List<Author> author { get; set; }
        public List<Reply> replies { get; set; }
        //public List<VersionHistory> __invalid_name__version-history { get; set; }
        //public List<WpFeaturedmedia> __invalid_name__wp:featuredmedia { get; set; }
        //public List<WpAttachment> __invalid_name__wp:attachment { get; set; }
        //public List<WpTerm> __invalid_name__wp:term { get; set; }
        //public List<Cury> curies { get; set; }
    }

    public class RootObject
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public DateTime date_gmt { get; set; }
       // public Guid guid { get; set; }
        public DateTime modified { get; set; }
        public DateTime modified_gmt { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string link { get; set; }
        public Title title { get; set; }
        public Content content { get; set; }
        public Excerpt excerpt { get; set; }
        public int author { get; set; }
        public int featured_media { get; set; }
        public string comment_status { get; set; }
        public string ping_status { get; set; }
        public bool sticky { get; set; }
        public string template { get; set; }
        public string format { get; set; }
        public List<object> meta { get; set; }
        public List<int> categories { get; set; }
        public List<object> tags { get; set; }
        public BetterFeaturedImage better_featured_image { get; set; }
        public Links _links { get; set; }
    }
}
