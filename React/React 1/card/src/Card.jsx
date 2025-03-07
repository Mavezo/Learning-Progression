import sralkPic from "./assets/sralk.png";
function Card() {
    return(
        <div className="card">
            <img className="card-image" src={sralkPic} alt="profile picture"/>
            <h2 className="card-title">RT</h2>
            <p className="card-text">React application</p>

        </div>

    );
}

export default Card