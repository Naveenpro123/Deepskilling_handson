import React from 'react';
import Post from './Post';

class Posts extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            posts: [],
            hasError: false
        };
    }

    loadPosts = () => {
        fetch('https://jsonplaceholder.typicode.com/posts')
            .then(response => response.json())
            .then(data => {
                this.setState({ posts: data });
            })
            .catch(error => {
                this.setState({ hasError: true });
                alert("Error fetching posts: " + error.message);
            });
    }

    componentDidMount() {
        this.loadPosts();
    }

    componentDidCatch(error, info) {
        this.setState({ hasError: true });
        alert("An error occurred: " + error.toString());
        console.error("Error info:", info);
    }

    render() {
        const { posts, hasError } = this.state;

        if (hasError) {
            return <h1>Something went wrong.</h1>;
        }

        return (
            <div>
                <h1 style={{ textAlign: 'center' }}>Blog Posts</h1>
                {posts.map(post => (
                    <Post key={post.id} title={post.title} body={post.body} />
                ))}
            </div>
        );
    }
}

export default Posts;
