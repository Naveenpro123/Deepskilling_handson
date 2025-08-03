import { BookDet } from './Components/BookDetails'; 

import { Coursedet } from './Components/CourseDetails';

import { Blogdet } from './Components/BlogDetails'; 
import './App.css'; 

function App() {
    return (
        <div className="container">
        
            <div className="st2">
                <h1>Course Details</h1>
                <Coursedet />

            </div>
            <div className="mystyle1">
                <h1>Book Details</h1>
                <BookDet />
            </div>
                <div className="v1">
                <h1>Blog Details</h1>
                <Blogdet />
                </div>
          </div> 
    );

}
export default App;
