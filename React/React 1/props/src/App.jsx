import Student from "./Student";

function App() {
  return (
    <>
      <Student name={20} age={30} isStudent={true}></Student>
      <Student name="Harry" age={20} isStudent={false}></Student>
      <Student name="Ron" age={15} isStudent={true}></Student>
      <Student name="Hermione" age={25} isStudent={false}></Student>
      <Student name="Draco" age={10} isStudent={true}></Student>
      <Student name="Neville" age={28} isStudent={false}></Student>
      <Student name="Severus" age={35} isStudent={true}></Student>
      
    </>
  );
}

export default App;