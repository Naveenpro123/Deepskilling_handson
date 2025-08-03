import './Office.css'; 
function OfficeRentalapp() {
    const element = "Office Space";
    const ItemName = { Name: "DBS", Rent: 50000, Address: "Chennai" };
    const jsxatt = <img src="/office.jpeg" width="25%" height="25%" alt="Office Space" /> 

    let color = []
    if (ItemName.Rent <= 60000) {
        color.push("textRed")
    } else {
        color.push("textGreen")
    }
  
  return (
    <div>
          <h1>{element},at Affordable Price</h1>
          {jsxatt}
          <h1>Name:{ItemName.Name}</h1>
          <h3 className={color}>Rent:{ItemName.Rent}</h3>
          <h3>Address:{ItemName.Address}</h3>
    </div>
  );
}
export default OfficeRentalapp;
