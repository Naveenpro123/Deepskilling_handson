import './Stylesheets/mystyle.css'; 
const Toperc = (decimal) => {
    return (decimal.toFixed(2) + '%');
}
const Calcu = (total, goal) => {
    return (Toperc(total / goal));
}
export const Calc = ({ Name, School, total, goal }) => (


    <div className="Format">
        <h1 style={{ color: 'brown' }}>Student Details</h1>
        <div className="Name">
            <b> <span>Name:
            </span></b>
            <span>{Name}</span>
        </div>
        <div className="School">
            <b> <span>School:
            </span></b>
            <span>{School}</span>
        </div>

        <div> <b> <span>Total:
        </span></b>
            <span>{total}Marks</span>


        </div>

        <div className="Score">
            <b><span>Score:</span></b>
            <span>{Calcu(total, goal)}</span>
            </div>
    </div>

);
