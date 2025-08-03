export const courses = [
    { name: "Angular", date: "4/5/2021" },
    { name: "React", date: "6/3/2021" }
];
export const Coursedet= ({ course }) => {
    return (
        <ul>

            {courses.map(c => (
                <div key={c.id}>
                    <h1>{c.name}</h1>
                    <h4>{c.date}</h4>
                </div>
            ))}

        </ul>
        
    );
};
