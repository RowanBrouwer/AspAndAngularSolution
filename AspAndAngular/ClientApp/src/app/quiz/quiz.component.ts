import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
/** Quiz component*/
export class QuizComponent {
  public question: Question = null;
  public max: number = 0;
  private questionNr:number = 1;
  private baseUrl: string;
  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  GetMaximumQuestions() {
    return this.http.get<number>(this.baseUrl + 'api/Question/GetMaxQuestions').subscribe(result => {
      this.max = result;
    }, error => console.error(error));
  }

  GetNextQuestion() {
    let callResult = this.http.get<Question>(this.baseUrl + 'api/Question/GetNextQuestion/Id', { params: new HttpParams().set( 'Id', this.questionNr.toString() ) }).subscribe(result => {
      this.question = result;
    }, error => console.error(error));
    this.questionNr++;
    return callResult;
  }

  ngOnInit() {
    this.GetMaximumQuestions();
    this.GetNextQuestion();
  }

 }

interface Question {
  Id: number;
  ActualQuestion: string;
  Awnsers: Awnser[];
  CorrectAwnser: Awnser;
  Chapter: ChapterEnum
}

interface Awnser {
  Id: number;
  ActualAwnser: string;
}

enum ChapterEnum {
  Azure_Core_Concepts,
  Azure_Core_Services,
  Azure_Core_Solutions_and_Management_tools,
  General_Security_and_Network_security,
  Identity_Governance_Privacy_and_Compliance_Features,
  Azure_Cost_Management_and_service_Level_Agreements
}
