


// class CommentBox extends React.Component {
//     render() {
//         return (
//             <div className="commentBox">Hello, world! I am a CommentBox.</div>
//         );
//     }
// }

// ReactDOM.render(<CommentBox />, document.getElementById('content'));

function request(url, params, method = 'GET') {

    const options = {
      method,
      headers: {
        'Content-Type': 'application/json' // we will be sending JSON
      }
    };
  
    // if params exists and method is GET, add query string to url
    // otherwise, just add params as a "body" property to the options object
    if (params) {
      if (method === 'GET') {
        url += '?' + objectToQueryString(params);
      } else {
        options.body = JSON.stringify(params); // body should match Content-Type in headers option
      }
    }
  
    const response = fetch(url, options);
    const result = response.json();
  
    return result;
  
  }

  function get(url, params) {
    return request(url, params);
  }
  
  function create(url, params) {
    return request(url, params, 'POST');
  }

  function update(url, params) {
    return request(url, params, 'PUT');
  }
  
  function remove(url, params) {
    return request(url, params, 'DELETE');
  }
  
  function objectToQueryString(obj) {
    return Object.keys(obj).map(key => key + '=' + obj[key]).join('&');
  }
