using System.Transactions;

public interface IStudent {
    
     string Name { get; set ;}

    void ListeningLection();

    void DoHomework(string exercise);

    void PrepareForExam();


}
