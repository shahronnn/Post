Post post1=new Post()
{
    Title="title 1",
    Description="description1",
};
Post post2=new Post()
{
    Title="title 2",
    Description="description2",
};
Post post3=new Post()
{
    Title="title 3",
    Description="description3",
};
Post post4=new Post()
{
    Title="title 4",
    Description="description4",
};

var postList=new List<Post>();
postList.Add(post1);
postList.Add(post2);
postList.Add(post3);
postList.Add(post4);

foreach (var post in postList)
{
    post.Publish();
}