export const blogs = [
    {
        title: "React Learning",
        author: "Stephen Biz",
        content: "Welcome to learning React!"
    },
    {
        title: "Installation",
        author: "Schwezdenier",
        content: "You can install React from npm."
    }
];

export const Blogdet = () => {

    return (
        <ul>
            {blogs.map((blogs, index) => (

                <div key={index}>
                <h1>{blogs.title}</h1>
                    <h4>Author: {blogs.author}</h4>
                    <p>{blogs.content}</p>
                </div>
            ))


            }
        </ul> 
    );

}
