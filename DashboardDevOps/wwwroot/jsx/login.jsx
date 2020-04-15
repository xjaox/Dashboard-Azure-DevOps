function updateState(text){
    this.setState(text);
}

class LoginComponent extends React.Component {
    constructor(props) {
        super(props);
        this.postLogin = this.postLogin.bind(this);
        this.handleInputChange = this.handleInputChange.bind(this);
        this.state;
      }
    
      handleInputChange(event) {
        const target = event.target;
        this.setState({[target.id]: target.value});
        updateState({[target.id]: target.value});
      }

      postLogin() {
        var data = this.state != null ? { user : this.state.txtUser, pass: this.state.txtPass } : null;

        if(data != null && data.user != "" && data.pass != ""){
            fetch('Login/Login', {
                method: 'POST', // *GET, POST, PUT, DELETE.
                body: JSON.stringify(data), // body data type must match "Content-Type" header
                headers: { 'Content-type': 'application/json; charset=UTF-8' }
                // mode: 'cors', // no-cors, *cors, same-origin
                // cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
                // credentials: 'same-origin', // include, *same-origin, omit
                // redirect: 'follow', // manual, *follow, error
                // referrerPolicy: 'no-referrer', // no-referrer, *client
            }).then(res => res.json())
            .then((result) => { updateState({result}) }, (error) => { updateState({error}) });
        }
        else{
            const result = { codigo: -1, messagem: ['Informe todos os dados!'] };
            updateState({result});
        }
    }

    render() {
        return (
            <div>
                <div className="form-group">
                    <input onChange={this.handleInputChange} id="txtUser" type="text" className="form-control" placeholder="Usuário" />
                </div>
                <div className="form-group">
                    <input onChange={this.handleInputChange} id="txtPass" type="password" className="form-control" placeholder="Senha" />
                </div>
                <button onClick={this.postLogin} id="btnLogin" className="btn btn-primary block full-width m-b">Login</button>
            </div>
        );
    }
}

class CallbackComponent extends React.Component {
    constructor(props) {
      super(props);
      this.state = { result: null, error: null };
      updateState = updateState.bind(this);
    }
  
    render() {
      const { result, error } = this.state;

      if (error) return <div>Error: {error.message}</div>;

      if(result == null){
        return <div>Error db: vazio</div>;
      } else if (result.codigo < 0) {
        return <div>Error db: {result.mensagem[0]}</div>;
      } else if (result.codigo >= 0) {
        return window.location.href = "Home"
      }
    }
  }

ReactDOM.render(<LoginComponent />, document.getElementById('content'));
ReactDOM.render(<CallbackComponent />, document.getElementById('content_buttom'));