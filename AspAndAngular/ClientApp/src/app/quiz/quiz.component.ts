import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Router, NavigationExtras } from '@angular/router';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})

/** Quiz component*/
export class QuizComponent {
  public question: Question;
  public max: number;
  private questionNr: number;
  private amountCorrect: number;
  private baseUrl: string;
  public correct: boolean;
  public deactivate: boolean;
  public lastQuestion: boolean;

    constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
      this.baseUrl = baseUrl;
      this.questionNr = 1;
      this.max = 0;
      this.amountCorrect = 0;
      this.correct = null;
      this.deactivate = false;
      this.lastQuestion = false;
    }

  GetMaximumQuestions() {
    this.http.get<number>(this.baseUrl + 'api/Question/GetMaxQuestions').subscribe(result => {
      this.max = result;
    }, error => console.error(error));
  }

  GetFirstQuestion(): void {
    this.http.get<Question>(`${this.baseUrl}api/Question/GetNextQuestion/Id`, { params: new HttpParams().set('Id', this.questionNr.toString()) }).subscribe(data => {
      this.question = data;
    }, error => console.error(error));
  }

  GetNextQuestion(): void { 
    this.correct = null;
    this.http.get<Question>(`${this.baseUrl}api/Question/GetNextQuestion/Id`, { params: new HttpParams().set('Id', this.questionNr.toString()) }).subscribe(data => {
      this.question = data;
    }, error => console.error(error));
      this.deactivate = false;
  }

  CheckAwnser(awnser: Awnser) {
    if (awnser.id === this.question.correctAnswer.id) {
      this.amountCorrect++;
      this.correct = true;
      this.deactivate = true;
      this.CheckIfLastQuestion();
    }
    else {
      this.correct = false;
      this.deactivate = true;
      this.CheckIfLastQuestion(); 
    }
  }

  Redirect() {
      let navigationExtras: NavigationExtras = {
        queryParams: {
          "totalAmount": this.questionNr,
          "amountCorrect": this.amountCorrect
        }
    };
    this.router.navigate(['/result'], navigationExtras);
  }

  CheckIfLastQuestion() {
    if (!(this.questionNr < this.max)) {
      this.lastQuestion = true;
    }
    else {
      this.questionNr++;
    }   
  }

  ngOnInit() {
    this.GetMaximumQuestions();
    this.GetFirstQuestion();
  }
}


export interface Awnser {
  id: Number;
  actualAwnser: String;
};

export enum ChapterEnum {
  Azure_Core_Concepts,
  Azure_Core_Services,
  Azure_Core_Solutions_and_Management_tools,
  General_Security_and_Network_security,
  Identity_Governance_Privacy_and_Compliance_Features,
  Azure_Cost_Management_and_service_Level_Agreements
};

export interface Question {
  id: Number;
  actualQuestion: String;
  awnsers: Awnser[];
  correctAnswer: Awnser;
  chapter: ChapterEnum;
};
