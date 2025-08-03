export const books = [
    { id: 101, bname: "Master React", price: 670 },
    { id: 102, bname: "Deep Dive into Angular 11", price: 800 },
    { id: 103, bname: "Mongo Essentials", price: 450 }
];

export const BookDet = ({ book }) => {
    return (
        <ul>
            {books.map(b => (

                <div key={b.id}>
                    <h1>{b.bname}</h1>
                    <h4>Price: ₹{b.price}</h4>
                </div>
            )) }
            
        </ul>
    );

};
